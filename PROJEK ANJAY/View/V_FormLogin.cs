using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.View;
using System.Drawing.Text;

namespace PROJEK_ANJAY
{
    public partial class V_FormLogin : Form
    {
        private AuthController authController;
        public V_FormLogin()
        {
            InitializeComponent();
            authController = new AuthController();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;

            if (ValidasiUser(user))
            {
                LoginkeAkun(user);
            }
        }

        private bool ValidasiUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Username dan Password harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void LoginkeAkun(User user)
        {
            var auth = authController.Login(user);
            if (auth)
            {
                MsgBerhasilLogin(user.Username);
                NavigateToForm(user);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MsgBerhasilLogin(string username)
        {
            MessageBox.Show($"Login berhasil. Selamat datang {username}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NavigateToForm(User user)
        {
            Form nextForm = MasukKeFormProduk(user);
            nextForm.Show();
        }
        private Form MasukKeFormProduk(User user)
        {
            if (IsAdmin(user))
            {
                return new V_Products();
            }
            else
            {
                return new V_FormDashboard(user);
            }
        }

        private bool IsAdmin(User user)
        {
            return user.Username == "admin" && user.Password == "Admin#123";
        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {}

        private void V_FormLogin_Load(object sender, EventArgs e)
        {}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            V_FormRegister FormRegist = new V_FormRegister();
            FormRegist.Show();
        }
    }
}
