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

namespace PROJEK_ANJAY
{
    public partial class V_Products : Form
    {
        private ProductController productController;
        private M_Products M_Products = new M_Products();
        public V_Products()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            productController = new ProductController();
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            V_CreateEditProduk createEditProduk = new V_CreateEditProduk();
            var result = createEditProduk.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Produk berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Produk gagal ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshData()
        {
            List<M_Products> DaftarProduk = productController.Products();

            dataGridView1.DataSource = productController.Products();
        }

        private void V_Products_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void V_Products_Load_1(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string btnItem = dataGridView1.Columns[e.ColumnIndex].Name;
            M_Products selectedProduct = (M_Products)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            M_Products = selectedProduct;
            if (btnItem == "Edit")
            {
                V_CreateEditProduk v_CreateEditProduk = new V_CreateEditProduk(M_Products);
                v_CreateEditProduk.ShowDialog();
                RefreshData();
                //MessageBox.Show("Anda klik edit", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnItem == "Delete")
            {
                productController.Delete(selectedProduct.Id);
                RefreshData();
            }

            //MessageBox.Show($"Produk {selectedProduct.NamaProduk} di klik", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if ()
            //{
            //    object=
            //}
        }
    }
}
