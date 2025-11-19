using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LONTAR
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        // ================================
        // EVENT TOMBOL REGISTER
        // ================================
        private void btregister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi kontrol
                if (tbuser == null || tbpw == null || tbemail == null || tbnotelp == null)
                {
                    MessageBox.Show("Terjadi masalah dengan kontrol input. Mohon coba lagi.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ambil input
                string username = tbuser.Text.Trim();
                string password = tbpw.Text.Trim();
                string email = tbemail.Text.Trim();
                string nohp = tbnotelp.Text.Trim();

                // Validasi nomor HP
                if (string.IsNullOrEmpty(nohp) || !Regex.IsMatch(nohp, @"^\d+$"))
                {
                    MessageBox.Show("Nomor HP harus berupa angka yang valid!",
                        "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validasi password
                if (string.IsNullOrEmpty(password) || password.Length <= 7 || !Regex.IsMatch(password, @"^\d+$"))
                {
                    MessageBox.Show("Kata sandi harus lebih dari 8 angka!",
                        "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate ID admin
                string newAdminId = GenerateNewAdminId();
                if (string.IsNullOrEmpty(newAdminId))
                {
                    MessageBox.Show("Gagal membuat ID admin baru.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Proses register ke database
                bool isRegistered = Register(newAdminId, username, email, nohp, username, password);

                if (isRegistered)
                {
                    MessageBox.Show("Registrasi Berhasil!", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("Registrasi Gagal. Silahkan coba lagi!",
                        "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ======================================
        // MENGAMBIL ID ADMIN TERAKHIR
        // ======================================
        private string GetLastAdminId()
        {
            string connStr = "Host=localhost;Username=postgres;Password=jodie123;Database=LONTAR";
            string lastId = null;

            string query = "SELECT id_admin FROM admin WHERE id_admin LIKE 'adm%' " +
                           "ORDER BY CAST(SUBSTRING(id_admin FROM 4) AS INT) DESC LIMIT 1";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lastId = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil ID admin terakhir: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lastId;
        }

        // ======================================
        // MEMBUAT ID ADMIN BARU
        // ======================================
        private string GenerateNewAdminId()
        {
            string lastId = GetLastAdminId();
            int newNumber = 1;

            if (!string.IsNullOrEmpty(lastId))
            {
                Match match = Regex.Match(lastId, @"^adm(\d+)$");
                if (match.Success && int.TryParse(match.Groups[1].Value, out int existingNumber))
                {
                    newNumber = existingNumber + 1;
                }
            }

            return "adm" + newNumber.ToString();
        }

        // ======================================
        // REGISTER KE DATABASE
        // ======================================
        private bool Register(string idAdmin, string nama, string email, string nohp, string username, string password)
        {
            string connStr = "Host=localhost;Username=postgres;Password=jodiefer;Database=CANKULLIN";

            string query = "INSERT INTO admin (id_admin, nama_admin, email, no_hp_admin, username, password) " +
                           "VALUES (@id_admin, @nama_admin, @email, @no_hp_admin, @username, @password)";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_admin", idAdmin);
                        cmd.Parameters.AddWithValue("@nama_admin", nama);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@no_hp_admin", nohp);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rows = cmd.ExecuteNonQuery();

                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registrasi Gagal: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
