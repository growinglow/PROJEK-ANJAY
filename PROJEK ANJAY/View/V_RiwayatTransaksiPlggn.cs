using System;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_ANJAY.View
{
    public partial class V_RiwayatTransaksiPlggn : Form
    {
        private User currentUser;
        private RiwayatTransaksiController riwayatController;

        public V_RiwayatTransaksiPlggn(User user)
        {
            InitializeComponent();
            currentUser = user;
            riwayatController = new RiwayatTransaksiController();
            tblRiwayatPlgn.AutoGenerateColumns = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                tblRiwayatPlgn.Rows.Clear();
                var listTransaksi = riwayatController.GetRiwayat(currentUser.Username);

                foreach (var transaksi in listTransaksi)
                {
                    int rowIndex = tblRiwayatPlgn.Rows.Add(transaksi.TanggalFormatted, transaksi.Barang, transaksi.TotalFormatted);
                    tblRiwayatPlgn.Rows[rowIndex].Tag = transaksi;
                }

                if (listTransaksi.Count == 0)
                {
                    MessageBox.Show("Tidak ada riwayat transaksi", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            V_FormDashboard v_FormDashboard = new V_FormDashboard(currentUser);
            v_FormDashboard.Show();
            this.Close();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            V_Pembayaran v_pembayaran = new V_Pembayaran(currentUser);
            v_pembayaran.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                V_FormLogin loginForm = new V_FormLogin();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
