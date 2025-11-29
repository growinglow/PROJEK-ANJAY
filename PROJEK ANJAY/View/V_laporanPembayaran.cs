using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROJEK_ANJAY.View
{
    public partial class V_laporanPembayaran : Form
    {
        private PayController payController;
        private User currentUser;

        public V_laporanPembayaran()
        {
            InitializeComponent();
            payController = new PayController();
            SettingCB();
            lblTotalJual.Text = "Pilih tahun untuk melihat laporan penjualan";
        }

        private void SettingCB()
        {
            for (int tahun = 2015; tahun <= DateTime.Now.Year; tahun++)
            {
                cbTahun.Items.Add(tahun);
            }
            cbTahun.Items.Insert(0, "Pilih Tahun");
            cbTahun.SelectedIndex = 0;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgLaporan.Rows.Clear();

                var semuaTransaksi = payController.GetTransaksiLunas();
                List<M_Pembayaran> listTransaksi;

                if (cbTahun.SelectedIndex > 0)
                {
                    int tahun = (int)cbTahun.SelectedItem;
                    listTransaksi = semuaTransaksi.FindAll(t => t.Tanggal.Year == tahun);
                }
                else
                {
                    listTransaksi = semuaTransaksi;
                    lblTotalJual.Text = "Pilih tahun untuk melihat laporan";
                }

                foreach (var transaksi in listTransaksi)
                {
                    int rowIndex = dgLaporan.Rows.Add(
                        transaksi.Tanggal.ToString("dd/MM/yyyy"),
                        transaksi.Username,
                        transaksi.Barang,
                        $"Rp {transaksi.Total:N0}"
                    );
                    dgLaporan.Rows[rowIndex].Tag = transaksi;
                }

                // HITUNG TOTAL
                int total = listTransaksi.Sum(t => t.Total);
                lblTotalJual.Text = $"Rp {total:N0} | {listTransaksi.Count} transaksi";

                if (listTransaksi.Count == 0)
                {
                    MessageBox.Show("Tidak ada transaksi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            V_Products v_products = new V_Products();
            v_products.Show();
            this.Close();
        }

        private void btnStatusTr_Click(object sender, EventArgs e)
        {
            V_StatusTransaksi v_StatusTransaksi = new V_StatusTransaksi();
            v_StatusTransaksi.Show();
            this.Close();
        }

        private void btnRiwayatTr_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksiAdm v_RiwayatTransaksiAdm = new V_RiwayatTransaksiAdm(currentUser);
            v_RiwayatTransaksiAdm.Show();
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
    }
}