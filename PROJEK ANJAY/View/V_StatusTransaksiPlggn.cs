using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;


namespace PROJEK_ANJAY.View
{
    public partial class V_StatusTransaksiPlggn : Form
    {
        private User currentUser;
        private StatusController statusController;
        private PayController payController;

        public V_StatusTransaksiPlggn(User user)
        {
            InitializeComponent();
            currentUser = user;
            payController = new PayController();
            statusController = new StatusController(); 

            LoadData(); 
        }

        private void LoadData()
        {
            try
            {
                if (dgStatus == null) return;

                dgStatus.Rows.Clear();

                var semuaTransaksi = statusController.GetTransaksiUsn(currentUser.Username)
                    .Where(t => t.Status != "Selesai") 
                    .ToList();

                foreach (var transaksi in semuaTransaksi)
                {
                    int rowIndex = dgStatus.Rows.Add();

                    dgStatus.Rows[rowIndex].Cells["tgl"].Value = transaksi.TanggalFormatted;
                    dgStatus.Rows[rowIndex].Cells["brg"].Value = transaksi.Barang;
                    dgStatus.Rows[rowIndex].Cells["total"].Value = transaksi.TotalFormatted;
                    dgStatus.Rows[rowIndex].Cells["statusskrg"].Value = transaksi.StatusDisplay;
                    dgStatus.Rows[rowIndex].Cells["alamat"].Value = transaksi.AlamatPengiriman;

                    dgStatus.Rows[rowIndex].Cells["statusskrg"].Style.ForeColor = transaksi.StatusColor;

                    dgStatus.Rows[rowIndex].Tag = transaksi;

                    UpdateTombolDiterima(rowIndex, transaksi.Status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTombolDiterima(int rowIndex, string status)
        {
            if (dgStatus.Columns["diterima"] == null) return;

            dgStatus.Rows[rowIndex].Cells["diterima"].Value = "Diterima";

            if (status == "Diproses")
            {
                dgStatus.Rows[rowIndex].Cells["diterima"].Value = "✅ Diterima";
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
            V_Pembayaran v_bayar = new V_Pembayaran(currentUser);
            v_bayar.Show();
            this.Close();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksiPlggn v_RiwayatTransaksiPlggn = new V_RiwayatTransaksiPlggn(currentUser);
            v_RiwayatTransaksiPlggn.Show();
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

        private void dgStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var transaksi = dgStatus.Rows[e.RowIndex].Tag as M_Pembayaran;
            if (transaksi == null) return;

            if (e.ColumnIndex == dgStatus.Columns["diterima"].Index && transaksi.Status == "Diproses")
            {
                DialogResult confirm = MessageBox.Show(
                    $"Konfirmasi pesanan telah diterima?\nStatus akan berubah menjadi SELESAI",
                    "Konfirmasi Penerimaan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    bool berhasil = statusController.UpdateStatus(transaksi.Id, "Selesai");

                    if (berhasil)
                    {
                        MessageBox.Show($"Pesanan berhasil dikonfirmasi sebagai SELESAI!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengupdate status.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private void UpdateStatus(int id, string statusBaru, string statusDisplay)
        //{
        //    DialogResult confirm = MessageBox.Show(
        //        $"Konfirmasi pesanan telah diterima?\nStatus akan berubah menjadi {statusDisplay}",
        //        "Konfirmasi Penerimaan",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );

        //    if (confirm == DialogResult.Yes)
        //    {
        //        bool berhasil = payController.UpdateStatus(id, statusBaru);

        //        if (berhasil)
        //        {
        //            MessageBox.Show($"Pesanan berhasil dikonfirmasi sebagai {statusDisplay}!", "Sukses",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LoadData(); // Refresh - transaksi akan hilang karena status sudah Selesai
        //        }
        //        else
        //        {
        //            MessageBox.Show("Gagal mengupdate status.", "Error",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
    }
}
