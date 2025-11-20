using Npgsql;
using PROJEK_ANJAY.DataBase;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Controllers
{
    internal class AuthController
    {
        private DbContext _dbContext;

        public AuthController()
        {
            _dbContext = new DbContext();
        }

        public bool Login(User user)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();
                string query = "SELECT 1 FROM users WHERE username = @username AND password = @password LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    using (var read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
        }

        public bool Register(User user)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();

                // 1. Cek apakah username sudah ada
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (var cmd = new NpgsqlCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Username sudah terdaftar
                        return false;
                    }
                }

                // 2. Jika belum ada, insert user baru
                string insertQuery = "INSERT INTO users (username, password, email, notelp) VALUES (@username, @password, @email, @notelp)";
                using (var cmd = new NpgsqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@notelp", user.Notelp);
                    cmd.ExecuteNonQuery();
                }
            }

            return true;
        }

        public void showFormLogin(Form form)
        {
            form.Hide();
            V_FormLogin formLogin = new V_FormLogin();
            formLogin.Show();
        }

        public void showFormRegister(Form form)
        {
            form.Hide();
            V_FormRegister formRegister = new V_FormRegister();
            formRegister.Show();
        }

        public void showDashboard(Form form, User user)
        {
            form.Hide();
            V_FormDashboard dashboard = new V_FormDashboard(user);
            dashboard.Show();
        }
    }
}
