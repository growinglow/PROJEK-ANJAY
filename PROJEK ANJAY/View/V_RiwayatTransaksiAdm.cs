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
    public partial class V_RiwayatTransaksiAdm : Form
    {
        private User currentUser;
        private RiwayatTransaksiController riwayatController;
        public V_RiwayatTransaksiAdm(User user)
        {
            InitializeComponent();
            currentUser = user;
            riwayatController = new RiwayatTransaksiController();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                tblRiwayatAdm.Rows.Clear();
                var listTransaksi = riwayatController.GetRiwayat("admin");

                foreach (var transaksi in listTransaksi)
                {
                    int rowIndex = tblRiwayatAdm.Rows.Add(transaksi.Id, transaksi.Username, transaksi.TanggalFormatted, transaksi.Barang, transaksi.TotalFormatted);
                    tblRiwayatAdm.Rows[rowIndex].Tag = transaksi;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            V_Products v_Products = new V_Products();
            v_Products.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                V_FormLogin loginForm = new V_FormLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void BtnLapPenjualan_Click(object sender, EventArgs e)
        {
            V_laporanPembayaran v_laporan = new V_laporanPembayaran();  
            v_laporan.Show();
            this.Close();
        }
    }
}
