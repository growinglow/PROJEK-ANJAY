using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_ANJAY.View
{
    public partial class V_FormDashboard : Form
    {
        private ProductController productController;
        private CartController cartController;
        private User currentUser;
        private List<M_Products> products;
        public V_FormDashboard(User user)
        {
            InitializeComponent();
            tblDashbord.AutoGenerateColumns = false;
            Qty.ReadOnly = true;
            currentUser = user;
            productController = new ProductController();
            cartController = new CartController();

            LoadProducts();
        }

        public void LoadProducts()
        {
            tblDashbord.SuspendLayout();

            try
            {
                products = productController.Products();
                tblDashbord.DataSource = null;
                tblDashbord.DataSource = products;

                foreach (DataGridViewRow row in tblDashbord.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Cells["Qty"].Value = 0;
                }
            }
            finally // maksud finally disini itu biar apapun yg terjadi di try, entah sukses atau error, kode di dalam finally tetep dijalankan. jadi kalo misal ada error pas ambil data produk, tetep layoutnya di-resume supaya UI ga macet. tapi kalo ga ada error juga tetep di-resume supaya layoutnya normal lagi. contoh casenya itu kayak misal pas ambil data produk ada error koneksi database, maka kode di dalam catch ga dijalankan, tapi kode di dalam finally tetep dijalankan supaya layoutnya di-resume. nah tapi disini kan gaada catch
            {
                tblDashbord.ResumeLayout();
            }
        }

        private int GetCurrentQuantity(DataGridViewCell cell)
        {
            if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int quantity))
            {
                return quantity;
            }
            return 0;
        }

        private void tblDashbord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= products.Count) return;

            M_Products selectedProduct = products[e.RowIndex];
            DataGridViewRow row = tblDashbord.Rows[e.RowIndex];
            DataGridViewCell qtyCell = row.Cells["Qty"];

            string columnName = tblDashbord.Columns[e.ColumnIndex].Name;

            if (columnName == "TambahQ")
            {
                int currentQty = GetCurrentQuantity(qtyCell);
                if (currentQty < selectedProduct.Stok)
                {
                    qtyCell.Value = currentQty + 1;
                }
                else
                {
                    MessageBox.Show($"Tidak bisa menambah! Stok hanya {selectedProduct.Stok} unit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (columnName == "Kurangiplis")
            {
                int currentQty = GetCurrentQuantity(qtyCell);
                if (currentQty > 1)
                {
                    qtyCell.Value = currentQty - 1;
                }
                else
                {
                    MessageBox.Show("Jumlah tidak bisa kurang dari 0.");
                }
            }
            else if (columnName == "AddToCart")
            {
                int quantity = GetCurrentQuantity(qtyCell);
                if (quantity <= 0)
                {
                    MessageBox.Show("Jumlah harus lebih dari 0 untuk ditambahkan ke keranjang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (cartController.AddToCart(currentUser.Username, selectedProduct.Id, quantity))
                {
                    MessageBox.Show($"{selectedProduct.NamaProduk} berhasil ditambahkan ke keranjang!");
                }
                else
                {
                    MessageBox.Show($"Gagal menambahkan {selectedProduct.NamaProduk} ke keranjang.");
                }
            }
        }

        private void LihatKeranjang_Click(object sender, EventArgs e)
        {
            V_Cart FormKeranjang = new V_Cart(currentUser, this);
            FormKeranjang.Show();
            this.Hide();

            LoadProducts();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            V_Pembayaran formPembayaran = new V_Pembayaran(currentUser);
            formPembayaran.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksiPlggn v_RiwayatTransaksiPlggn = new V_RiwayatTransaksiPlggn(currentUser);
            v_RiwayatTransaksiPlggn.Show();
            this.Close();
        }
    }
}
