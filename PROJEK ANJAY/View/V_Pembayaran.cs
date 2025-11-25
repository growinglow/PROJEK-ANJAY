using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_ANJAY.View
{
    public partial class V_Pembayaran : Form
    {
        private User currentUser;
        private PayController payController;

        public V_Pembayaran(User user)
        {
            InitializeComponent();
            currentUser = user;
            payController = new PayController();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                tblPembayaran.Rows.Clear();
                var listTransaksi = payController.GetTransaskiBlmByr(currentUser.Username);
                foreach (var transaksi in listTransaksi)
                {
                    int rowIndex = tblPembayaran.Rows.Add(
                        transaksi.Tanggal, transaksi.Barang, transaksi.Total, transaksi.Status);
                    tblPembayaran.Rows[rowIndex].Tag = transaksi;
                }
                if (listTransaksi.Count == 0)
                {
                    MessageBox.Show("Tidak ada transaksi yang belum dibayar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != tblPembayaran.Columns["BayarSkrg"].Index)
                return;

            var transaksi = tblPembayaran.Rows[e.RowIndex].Tag as M_Pembayaran;

            if (transaksi != null)
            {
                int transaksiId = transaksi.Id;
                string total = transaksi.TotalFormatted; 

                var hasil = MessageBox.Show($"Bayar transaksi dengan total {total}?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    try
                    {
                        bool berhasil = payController.BayarSekarang(transaksiId);
                        if (berhasil)
                        {
                            MessageBox.Show("Pembayaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Pembayaran gagal. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saat melakukan pembayaran: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            string username = currentUser.Username;

            var formRiwayat = new V_RiwayatTransaksi(username);
            formRiwayat.Show();
            this.Close();
        }

        private void V_Pembayaran_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin logout?", "Konfirmasi",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                V_FormLogin formLogin = new V_FormLogin();
                formLogin.Show();
                this.Close(); // atau this.Close() tergantung kebutuhan
            }
        }
    }
}
