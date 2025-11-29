using Npgsql;
using PROJEK_ANJAY.DataBase;
using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Controllers
{
    public class ProductController
    {
        private DbContext Context; 
        public ProductController()
        {
            Context = new DbContext(); 
        }
        public List<M_Products> Products()
        {
            List<M_Products> products = new List<M_Products>();
            using (var conn = new NpgsqlConnection(Context.connStr))
            {
                conn.Open();
                string query = "SELECT id, nama_produk, deskripsi, harga, stok, is_active FROM products WHERE is_active = true ORDER BY id ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                { 
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            products.Add(new M_Products
                            {
                                Id = reader.GetInt32(0),
                                NamaProduk = reader.GetString(1),
                                Deskripsi = reader.GetString(2),
                                Harga = reader.GetInt32(3),
                                Stok = reader.GetInt32(4),
                                IsActive = reader.GetBoolean(5)
                            });
                        }
                    }
                }
            }
            return products;
        }
        public bool Create(M_Products products)
        {
            using (var conn = new NpgsqlConnection(Context.connStr))
            {
                conn.Open(); 
                string query = "INSERT INTO products (nama_produk, deskripsi, harga, stok) VALUES (@nama_produk, @deskripsi, @harga, @stok)"; // nah yang ada @ itu placeholder, kyk tempat kosong
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_produk", products.NamaProduk);
                    cmd.Parameters.AddWithValue("@deskripsi", products.Deskripsi);
                    cmd.Parameters.AddWithValue("@harga", products.Harga);
                    cmd.Parameters.AddWithValue("@stok", products.Stok);

                    int var = cmd.ExecuteNonQuery();
                    if (var > 0) 
                    {
                        return true;
                    }
                    else
                    {
                        return false; 
                    }
                }
            }
        }
        public bool Delete(int id)
        {
            DialogResult result = MessageBox.Show(
                "Yakin ingin menon-aktifkan produk ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return false;
            }

            using (var conn = new NpgsqlConnection(Context.connStr))
            {
                conn.Open();

                string query = "UPDATE products SET is_active = false WHERE id = @Id"; 
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id); 
                    int rowsAffected = cmd.ExecuteNonQuery(); 

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produk berhasil di non-aktifkan");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Produk tidak ditemukan");
                        return false;
                    }
                }
            }
        }
        public bool Update(M_Products products)
        {
            using (var conn = new NpgsqlConnection(Context.connStr))
            {
                conn.Open();
                string query = "UPDATE products SET nama_produk = @nama_produk, deskripsi = @deskripsi, harga = @harga, stok = @stok WHERE id = @Id";
                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@nama_Produk", products.NamaProduk); 
                    conn2.Parameters.AddWithValue("@deskripsi", products.Deskripsi);
                    conn2.Parameters.AddWithValue("@harga", products.Harga);
                    conn2.Parameters.AddWithValue("@stok", products.Stok);
                    conn2.Parameters.AddWithValue("@id", products.Id);

                    int var = conn2.ExecuteNonQuery();
                    if (var > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}

