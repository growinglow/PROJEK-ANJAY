using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.View;

namespace PROJEK_ANJAY
{
    public partial class V_FormLogin : Form
    {
        private AuthController _authController;
        public V_FormLogin()
        {
            InitializeComponent();
            _authController = new AuthController();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Username dan Password harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var auth = _authController.Login(user);
            if (auth)
            {
                MessageBox.Show($"Login berhasil. Selamat datang {user.Username}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                if (user.Username == "admin" && user.Password == "Admin#123")
                {
                    // buka form produk
                    V_Products produk = new V_Products();
                    produk.Show();
                }
                else
                {
                    // buka form dashboard
                    V_FormDashboard dashboard = new V_FormDashboard(user);
                    dashboard.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah. Silahkan periksa kredensial akun anda!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
