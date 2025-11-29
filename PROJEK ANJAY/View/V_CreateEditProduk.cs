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
using static System.Windows.Forms.AxHost;

namespace PROJEK_ANJAY
{
    public partial class V_CreateEditProduk : Form
    {
        private ProductController productController;
        private M_Products M_Products = new M_Products();
        private string state = "Tambah";

        public V_CreateEditProduk()
        {
            InitializeComponent();
            productController = new ProductController();

        }
        public V_CreateEditProduk(M_Products m_Products)
        {
            state = "Edit";
            InitializeComponent();
            M_Products = m_Products;
            productController = new ProductController();
            tbNamaProduk.Text = M_Products.NamaProduk;
            tbDeskripsi.Text = M_Products.Deskripsi;
            tbHarga.Text = M_Products.Harga.ToString();
            tbStok.Text = M_Products.Stok.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            M_Products.NamaProduk = tbNamaProduk.Text;
            M_Products.Deskripsi = tbDeskripsi.Text;
            M_Products.Harga = int.Parse(tbHarga.Text);
            M_Products.Stok = int.Parse(tbStok.Text);

            if (state == "Tambah")
            {
                productController.Create(M_Products);
            }
            else if (state == "Edit")
            {
                productController.Update(M_Products);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
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
