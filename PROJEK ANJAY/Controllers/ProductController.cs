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
                string query = "SELECT * FROM products ORDER BY id ASC";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    using (var reader = conn2.ExecuteReader())
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
                string query = "INSERT INTO products (nama_produk, deskripsi, harga, stok) VALUES (@nama_produk, @deskripsi, @harga, @stok)";

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
            using (var conn = new NpgsqlConnection(Context.connStr))
            {
                conn.Open();
                string query = "DELETE FROM products WHERE id = @Id";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@Id", id);

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

