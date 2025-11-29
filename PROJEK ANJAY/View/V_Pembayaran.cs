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

                string vaNumber = "8881234567890"; //stati
                string bankName = "BANK SILONTAR";

                var konfirmasi = MessageBox.Show(
                    $"Bayar transaksi dengan total {total}?\n\n" +
                    $"Silakan transfer ke:\n" +
                    $"Bank: {bankName}\n" +
                    $"VA Number: {vaNumber}\n\n" +
                    $"Setelah transfer, status akan otomatis berubah menjadi SUDAH BAYAR.",
                    "Konfirmasi Pembayaran",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (konfirmasi == DialogResult.Yes)
                {
                    try
                    {
                        bool berhasil = payController.BayarSekarang(transaksiId);
                        if (berhasil)
                        {
                            MessageBox.Show(
                                "Pembayaran berhasil!\n\n" +
                                "Terima kasih telah melakukan pembayaran. " +
                                "Pesanan Anda akan segera diproses setelah pembayaran dikonfirmasi.",
                                "Sukses",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            LoadData(); // Refresh data
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
            V_RiwayatTransaksiPlggn v_RiwayatTransaksiPlggn = new V_RiwayatTransaksiPlggn(currentUser);
            v_RiwayatTransaksiPlggn.Show();
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
                this.Close();
            }
        }

        private void btnProduk1_Click(object sender, EventArgs e)
        {
            V_FormDashboard formDashboard = new V_FormDashboard(currentUser);
            formDashboard.Show();
            this.Close(); 
        }
    }
}
