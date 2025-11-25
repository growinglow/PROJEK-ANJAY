using PROJEK_ANJAY.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJEK_ANJAY.Models;

namespace PROJEK_ANJAY
{
    public partial class V_FormRegister : Form
    {
        private AuthController _authController;
        public V_FormRegister()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void V_FormRegister_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showFormLogin(this);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            user.Email = tbEmail.Text;
            user.Notelp = tbNotelp.Text;

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Notelp))
            {
                MessageBox.Show("Semua data harap diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var auth = _authController.Register(user);

            if (auth)
            {
                MessageBox.Show("Registrasi Berhasil. Silahkan Login dengan akun anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _authController.showFormLogin(this);
            }
            else
            {
                MessageBox.Show("Username sudah ada. Gunakan username lain.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNotelp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
