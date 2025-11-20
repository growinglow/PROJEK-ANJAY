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
    public partial class V_FormDashboard : Form
    {
        private ProductController productController;
        private CartController cartController;
        private User currentUser;
        private List<M_Products> products;
        private string welcomeMessage = "Welcome to our dashboard";
        public V_FormDashboard(User user)
        {
            InitializeComponent();
            tblDashbord.AutoGenerateColumns = false;
            currentUser = user;
            productController = new ProductController();
            cartController = new CartController();
            lblWelcome.Text = $"{welcomeMessage}, {currentUser.Username}!";

            LoadProducts();
        }

        public void LoadProducts()  // ← INI METHOD YANG DIMAKSUD
        {
            // Suspend layout untuk menghindari refresh berulang
            tblDashbord.SuspendLayout();

            try
            {
                products = productController.Products();
                tblDashbord.DataSource = null; // Clear dulu
                tblDashbord.DataSource = products;

                foreach (DataGridViewRow row in tblDashbord.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Cells["Qty"].Value = 0;
                }
            }
            finally
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
            return 0; // Default value jika parsing gagal
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
                if (currentQty < selectedProduct.Stok) // ← DIPERBAIKI
                {
                    qtyCell.Value = currentQty + 1;
                }
                else
                {
                    MessageBox.Show($"Tidak bisa menambah! Stok hanya {selectedProduct.Stok} unit.");
                }
            }
            else if (columnName == "Kurangiplis")
            {
                int currentQty = GetCurrentQuantity(qtyCell);
                if (currentQty > 1)
                {
                    qtyCell.Value = currentQty - 1; // ✅ REAL-TIME UPDATE
                }
                else
                {
                    MessageBox.Show("Jumlah tidak bisa kurang dari 0.");
                }
            }
            else if (columnName == "AddToCart")
            {
                int quantity = GetCurrentQuantity(qtyCell);

                if (cartController.AddToCart(currentUser.Username, selectedProduct.Id, quantity))
                {
                    MessageBox.Show($"{selectedProduct.NamaProduk} berhasil ditambahkan ke keranjang!");
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
    }
}
