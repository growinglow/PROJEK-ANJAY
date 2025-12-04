using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PROJEK_ANJAY.View
{
    public partial class V_Cart : Form
    {
        private CartController cartController;
        private User currentUser;
        private List<M_Keranjang> ItemKeranjang;
        private V_FormDashboard formDashboard;
        public V_Cart(User user, V_FormDashboard dashboardForm)
        {
            InitializeComponent();
            tblKeranjang.AutoGenerateColumns = false;
            currentUser = user;
            cartController = new CartController();
            formDashboard = dashboardForm;

            LoadItemKeranjang();
        }

        private void LoadItemKeranjang()
        {
            try
            {
                ItemKeranjang = cartController.GetItemKeranjang(currentUser.Username);
                tblKeranjang.Rows.Clear();
                foreach (var item in ItemKeranjang)
                {
                    int rowIndex = tblKeranjang.Rows.Add(
                        item.NamaProduk,
                        item.Harga,
                        item.Quantity,
                        item.SubTotal
                    );
                }

                CalculateTotal();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cart: {ex.Message}");
            }
        }

        private void CalculateTotal()
        {
            double total = ItemKeranjang.Sum(item => item.SubTotal);
            lblTotal.Text = $"Total: Rp {total:N0}";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi keranjang tidak kosong
                if (ItemKeranjang == null || ItemKeranjang.Count == 0)
                {
                    MessageBox.Show("Keranjang belanja kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi alamat
                if (string.IsNullOrEmpty(tbAlamat.Text.Trim()))
                {
                    MessageBox.Show("Mohon isi alamat pengiriman!", "Perhatian",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbAlamat.Focus();
                    return;
                }

                double total = ItemKeranjang.Sum(item => item.SubTotal);
                string totalFormatted = $"Rp {total:N0}";

                StringBuilder detailPesanan = new StringBuilder();
                detailPesanan.AppendLine("Detail Pesanan");

                foreach (var item in ItemKeranjang)
                {
                    detailPesanan.AppendLine($"{item.NamaProduk} ({item.Quantity}x) = Rp {item.SubTotal:N0}");
                }

                detailPesanan.AppendLine("");
                detailPesanan.AppendLine($"TOTAL: {totalFormatted}");
                detailPesanan.AppendLine($"Alamat: {tbAlamat.Text.Trim()}");

                DialogResult konfirmasi1 = MessageBox.Show(
                    detailPesanan.ToString() + "\n" +
                    "Yakin ingin membuat pesanan?",
                    "Konfirmasi Checkout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (konfirmasi1 != DialogResult.Yes)
                {
                    return; // User membatalkan
                }

                bool sukses = cartController.SimpanTransaksi(currentUser.Username, ItemKeranjang, tbAlamat.Text.Trim());

                if (sukses)
                {
                    cartController.ClearKeranjang(currentUser.Username);
                    MessageBox.Show(
                        $"Pesanan Berhasil Dibuat!\n\n" +
                        $"Total: {totalFormatted}\n" +
                        $"Segera lakukan pembayaran di menu 'Pembayaran'.\n\n" +
                        $"Pesanan akan diproses setelah pembayaran dikonfirmasi.",
                        "Sukses Checkout",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    if (formDashboard != null && !formDashboard.IsDisposed)
                    {
                        formDashboard.LoadProducts(); 
                        formDashboard.Show();
                        formDashboard.BringToFront();
                    }
                    else
                    {
                        V_FormDashboard newDashboard = new V_FormDashboard(currentUser);
                        newDashboard.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal membuat pesanan. Silakan coba lagi.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            if (ItemKeranjang.Count > 0)
            {
                var result = MessageBox.Show("Jika kamu kembali, semua item keranjang akan hilang. yakin ingin kembali?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cartController.ClearKeranjang(currentUser.Username);
                    formDashboard.Show();
                }
            }
            else
            {
                formDashboard.Show();
            }
            Debug.WriteLine("btnKembali_Click dipanggil");

        //    if (ItemKeranjang.Count > 0)
        //    {
        //        Debug.WriteLine("Keranjang tidak kosong");
        //        var result = MessageBox.Show("Jika kamu kembali, semua item keranjang akan hilang. yakin ingin kembali?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        Debug.WriteLine($"User memilih: {result}");

        //        if (result == DialogResult.Yes)
        //        {
        //            Debug.WriteLine("User memilih Yes");
        //            cartController.ClearKeranjang(currentUser.Username);
        //            Debug.WriteLine("Keranjang berhasil dikosongkan");
        //            formDashboard.Show();
        //            Debug.WriteLine("Dashboard ditampilkan");
        //            this.Close();
        //            Debug.WriteLine("Form Cart ditutup");
        //        }
        //        else
        //        {
        //            Debug.WriteLine("User memilih No");
        //        }
        //    }
        //    else
        //    {
        //        Debug.WriteLine("Keranjang kosong");
        //        formDashboard.Show();
        //        this.Close();
        //    }
        //}
        }

        private void btnBayarNanti_Click(object sender, EventArgs e)
        {
            //if (ItemKeranjang.Count == 0)
            //{
            //    MessageBox.Show("Keranjang belanja kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //double total = ItemKeranjang.Sum(item => item.SubTotal);
            //var result = MessageBox.Show($"Buat pesanan dengan total Rp{total:N0}?",
            //    "Konfirmasi Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    try
            //    {
            //        bool simpanTransaksi = cartController.SimpanTransaksi(currentUser.Username, ItemKeranjang, false);
            //        if (!simpanTransaksi)
            //        {
            //            MessageBox.Show("Gagal menyimpan transaksi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //        foreach (var item in ItemKeranjang)
            //        {
            //            bool stockUpdated = cartController.UpdateStokProduk(item.ProductId, item.Quantity);

            //            if (!stockUpdated)
            //            {
            //                MessageBox.Show($"Gagal update stok untuk {item.NamaProduk}. Stok tidak cukup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //        }

            //        if (cartController.ClearKeranjang(currentUser.Username))
            //        {
            //            MessageBox.Show("Pesanan berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            if (formDashboard != null)
            //            {
            //                formDashboard.Show();
            //                formDashboard.LoadProducts();
            //            }
            //            this.Close();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error saat checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            V_Pembayaran formPembayaran = new V_Pembayaran(currentUser);
            formPembayaran.Show();
            this.Hide();
        }

        private void tblKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksiPlggn v_Riwayat = new V_RiwayatTransaksiPlggn(currentUser);
            v_Riwayat.Show();
            this.Close();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            V_StatusTransaksiAdm v_Status = new V_StatusTransaksiAdm();
            v_Status.Show();
            this.Close();
        }
    }
}
