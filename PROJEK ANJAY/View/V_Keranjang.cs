using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using System;
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
    public partial class V_Keranjang : Form
    {
        private CartController cartController;
        private User currentUser;
        private List<M_Keranjang> ItemKeranjang;
        private V_FormDashboard formDashboard;
        public V_Keranjang(User user, V_FormDashboard dashboardForm)
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

                //CalculateTotal();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cart: {ex.Message}");
            }
        }
        //private void CalculateTotal()
        //{
        //    double total = ItemKeranjang.Sum(item => item.SubTotal);
        //    lblTotal.Text = $"Total: Rp {total:N0}";
        //}

        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi
                if (string.IsNullOrEmpty(tbAlamat.Text.Trim()))
                {
                    MessageBox.Show("Isi alamat pengiriman!");
                    return;
                }

                // Simpan transaksi
                List<M_Keranjang> cartItems = cartController.GetItemKeranjang(currentUser.Username);
                bool sukses = cartController.SimpanTransaksi(currentUser.Username, cartItems, tbAlamat.Text);

                if (sukses)
                {
                    // Kosongkan keranjang
                    cartController.ClearKeranjang(currentUser.Username);

                    MessageBox.Show("✅ Checkout berhasil!\nKembali ke halaman utama...",
                                  "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // **SOLUSI YANG PASTI:**
                    // 1. Cari dashboard yang masih ada
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is V_FormDashboard && !form.IsDisposed)
                        {
                            // Refresh dan tampilkan
                            ((V_FormDashboard)form).LoadProducts();
                            form.Show();
                            form.BringToFront(); // Pastikan di depan
                            break;
                        }
                    }

                    V_FormDashboard v_FormDashboard = new V_FormDashboard(currentUser);
                    v_FormDashboard.Show();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error saat checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
