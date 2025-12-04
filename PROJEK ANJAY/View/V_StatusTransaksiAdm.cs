using PROJEK_ANJAY.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_ANJAY.View
{
    public partial class V_StatusTransaksiAdm : Form
    {
        private PayController payController;
        private StatusController statusController;
        public V_StatusTransaksiAdm()
        {
            InitializeComponent();
            payController = new PayController();
            statusController = new StatusController();
            dgStatus.CellContentClick += dgStatus_CellContentClick;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgStatus.Rows.Clear();

                var semuaTransaksi = statusController.GetTransaksiblmselesai();

                foreach (var transaksi in semuaTransaksi)
                {
                    int rowIndex = dgStatus.Rows.Add();

                    dgStatus.Rows[rowIndex].Cells["tgl"].Value = transaksi.TanggalFormatted;
                    dgStatus.Rows[rowIndex].Cells["usn"].Value = transaksi.Username;
                    dgStatus.Rows[rowIndex].Cells["brg"].Value = transaksi.Barang;
                    dgStatus.Rows[rowIndex].Cells["total"].Value = transaksi.TotalFormatted;
                    dgStatus.Rows[rowIndex].Cells["statusskrg"].Value = transaksi.StatusDisplay;

                    dgStatus.Rows[rowIndex].Cells["statusskrg"].Style.ForeColor = transaksi.StatusColor;

                    dgStatus.Rows[rowIndex].Tag = transaksi;

                    tombolUpdate(rowIndex, transaksi.Status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tombolUpdate(int rowIndex, string status)
        {
            dgStatus.Rows[rowIndex].Cells["lunas"].Style.ForeColor = Color.Gray;
            dgStatus.Rows[rowIndex].Cells["lunas"].Value = "Lunas";

            dgStatus.Rows[rowIndex].Cells["proses"].Style.ForeColor = Color.Gray;
            dgStatus.Rows[rowIndex].Cells["proses"].Value = "Proses";

            if (status == "BelumBayar")
            {
                dgStatus.Rows[rowIndex].Cells["lunas"].Style.ForeColor = Color.Green;
                dgStatus.Rows[rowIndex].Cells["lunas"].Value = "💵 Lunas";
            }
            else if (status == "Lunas")
            {
                dgStatus.Rows[rowIndex].Cells["proses"].Style.ForeColor = Color.Blue;
                dgStatus.Rows[rowIndex].Cells["proses"].Value = "🚚 Proses";
            }
            // Status "Diproses" tidak perlu tombol aktif
        }

        private void dgStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var transaksi = dgStatus.Rows[e.RowIndex].Tag as M_Pembayaran;
            if (transaksi == null) return;

            if (e.ColumnIndex == dgStatus.Columns["lunas"].Index && transaksi.Status == "BelumBayar")
            {
                UpdateStatusTransaksi(transaksi.Id, "Lunas", "LUNAS");
            }
            else if (e.ColumnIndex == dgStatus.Columns["proses"].Index && transaksi.Status == "Lunas")
            {
                UpdateStatusTransaksi(transaksi.Id, "Diproses", "DIPROSES");
            }
        }
        private void UpdateStatusTransaksi(int id, string statusBaru, string statusDisplay)
        {
            DialogResult confirm = MessageBox.Show(
                $"Ubah status transaksi menjadi {statusDisplay}?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool berhasil = statusController.UpdateStatus(id, statusBaru);

                if (berhasil)
                {
                    MessageBox.Show($"Status berhasil diubah menjadi {statusDisplay}!", "Sukses");
                    LoadData();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksiAdm v_RiwayatTransaksiAdm = new V_RiwayatTransaksiAdm();
            v_RiwayatTransaksiAdm.Show();
            this.Close();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            V_Products v_products = new V_Products();
            v_products.Show();
            this.Close();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            V_laporanPembayaran v_lap = new V_laporanPembayaran();
            v_lap.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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
    }
}
