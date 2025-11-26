using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

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
            if (ItemKeranjang.Count == 0)
            {
                MessageBox.Show("Keranjang belanja kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double total = ItemKeranjang.Sum(item => item.SubTotal);
            var result = MessageBox.Show($"Checkout dengan total Rp{total:N0}?",
                "Konfirmasi Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool simpanTransaksi = cartController.SimpanTransaksi(currentUser.Username, ItemKeranjang, true);
                    if (!simpanTransaksi)
                    {
                        MessageBox.Show("Gagal menyimpan transaksi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    foreach (var item in ItemKeranjang)
                    {
                        bool stockUpdated = cartController.UpdateStokProduk(item.ProductId, item.Quantity);

                        if (!stockUpdated)
                        {
                            MessageBox.Show($"Gagal update stok untuk {item.NamaProduk}. Stok mungkin tidak cukup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (cartController.ClearKeranjang(currentUser.Username))
                    {
                        MessageBox.Show("Checkout berhasil dilakukan! Segera lakukan pembayaran agar pesananmu dapat segera kami kirim", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (formDashboard != null)
                        {
                            formDashboard.Show();
                            formDashboard.LoadProducts();
                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        }

        private void btnBayarNanti_Click(object sender, EventArgs e)
        {
            if (ItemKeranjang.Count == 0)
            {
                MessageBox.Show("Keranjang belanja kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double total = ItemKeranjang.Sum(item => item.SubTotal);
            var result = MessageBox.Show($"Buat pesanan dengan total Rp{total:N0}?",
                "Konfirmasi Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool simpanTransaksi = cartController.SimpanTransaksi(currentUser.Username, ItemKeranjang, false);
                    if (!simpanTransaksi)
                    {
                        MessageBox.Show("Gagal menyimpan transaksi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    foreach (var item in ItemKeranjang)
                    {
                        bool stockUpdated = cartController.UpdateStokProduk(item.ProductId, item.Quantity);

                        if (!stockUpdated)
                        {
                            MessageBox.Show($"Gagal update stok untuk {item.NamaProduk}. Stok tidak cukup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (cartController.ClearKeranjang(currentUser.Username))
                    {
                        MessageBox.Show("Pesanan berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (formDashboard != null)
                        {
                            formDashboard.Show();
                            formDashboard.LoadProducts();
                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saat checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
