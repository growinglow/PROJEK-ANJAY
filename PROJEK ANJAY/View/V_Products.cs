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
            RefreshData(); 
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

            try 
            {
                var products = productController.Products();
                dataGridView1.DataSource = products;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error refresh data: {ex.Message}");
            }
        }

        private void V_Products_Load(object sender, EventArgs e)
        {
            RefreshData(); //
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
            V_RiwayatTransaksiAdm riwayatTransaksiAdm = new V_RiwayatTransaksiAdm(new User { Username = "admin" });
            riwayatTransaksiAdm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            V_Products v_Products = new V_Products();
            v_Products.Show();
            this.Hide();
        }

        private void btnLapPenjualan_Click(object sender, EventArgs e)
        {
            V_laporanPembayaran v_LaporanPembayaran = new V_laporanPembayaran();
            v_LaporanPembayaran.Show();
            this.Close();
        }
    }
}
