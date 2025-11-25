using Npgsql;
using PROJEK_ANJAY.DataBase;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.View;
using PROJEK_ANJAY.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Controllers
{
    public class CartController
    {
        private DbContext _context;

        public CartController()
        {
            _context = new DbContext();
        }

        // ✅ METHOD 1: ADD TO CART
        public bool AddToCart(string username, int productId, int quantity)
        {
            using (var conn = new NpgsqlConnection(_context.connStr))
            {
                conn.Open();

                // Cek apakah produk sudah ada di keranjang user
                string checkQuery = "SELECT quantity FROM cart WHERE username = @username AND product_id = @product_id";
                using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@product_id", productId);

                    var existingQuantity = checkCmd.ExecuteScalar();

                    if (existingQuantity != null)
                    {
                        // Update quantity jika sudah ada
                        string updateQuery = "UPDATE cart SET quantity = quantity + @quantity WHERE username = @username AND product_id = @product_id";
                        using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@quantity", quantity);
                            updateCmd.Parameters.AddWithValue("@username", username);
                            updateCmd.Parameters.AddWithValue("@product_id", productId);

                            return updateCmd.ExecuteNonQuery() > 0;
                        }
                    }
                    else
                    {
                        // Tambah baru jika belum ada
                        string insertQuery = "INSERT INTO cart (username, product_id, quantity) VALUES (@username, @product_id, @quantity)";
                        using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@username", username);
                            insertCmd.Parameters.AddWithValue("@product_id", productId);
                            insertCmd.Parameters.AddWithValue("@quantity", quantity);

                            return insertCmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
            }
        }

        // ✅ METHOD 2: GET ITEM KERANJANG
        public List<M_Keranjang> GetItemKeranjang(string username)
        {
            List<M_Keranjang> keranjangItems = new List<M_Keranjang>();
            using (var conn = new NpgsqlConnection(_context.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT c.id, c.username, c.product_id, p.nama_produk, p.harga, c.quantity 
                    FROM cart c 
                    INNER JOIN products p ON c.product_id = p.id 
                    WHERE c.username = @username";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            keranjangItems.Add(new M_Keranjang
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                ProductId = reader.GetInt32(2),
                                NamaProduk = reader.GetString(3),
                                Harga = reader.GetDouble(4),
                                Quantity = reader.GetInt32(5)
                            });
                        }
                    }
                }
            }
            return keranjangItems;
        }

        // ✅ METHOD 3: CLEAR KERANJANG (CHECKOUT)
        public bool ClearKeranjang(string username)
        {
            using (var conn = new NpgsqlConnection(_context.connStr))
            {
                conn.Open();
                string query = "DELETE FROM cart WHERE username = @username";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ✅ METHOD 4: UPDATE QUANTITY (OPTIONAL)
        public bool UpdateCartItem(int cartId, int quantity)
        {
            using (var conn = new NpgsqlConnection(_context.connStr))
            {
                conn.Open();
                string query = "UPDATE cart SET quantity = @quantity WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@id", cartId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ✅ METHOD 5: REMOVE FROM CART (OPTIONAL)
        public bool RemoveFromCart(int cartId)
        {
            using (var conn = new NpgsqlConnection(_context.connStr))
            {
                conn.Open();
                string query = "DELETE FROM cart WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", cartId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        // ✅ METHOD 6: UPDATE STOK SETELAH CHECKOUT
        public bool UpdateStokProduk(int productId, int quantitySold)
        {
            using (var conn = new NpgsqlConnection(_context.connStr))
            {
                conn.Open();
                string query = "UPDATE products SET stok = stok - @quantity WHERE id = @product_id AND stok >= @quantity";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantitySold);
                    cmd.Parameters.AddWithValue("@product_id", productId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool SimpanTransaksi(string username, List<M_Keranjang> cartItems, bool isPaid)
        {
            using (var conn = new NpgsqlConnection(_context.connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. INSERT HEADER TRANSAKSI
                        string query1 = @"
                    INSERT INTO transaksi (username, total, is_paid) 
                    VALUES (@username, @total, @is_paid) 
                    RETURNING id";

                        int totalAmount = (int)cartItems.Sum(item => item.SubTotal);

                        int transaksiId;
                        using (var cmd = new NpgsqlCommand(query1, conn))
                        {
                            cmd.Transaction = transaction;
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@total", totalAmount);
                            cmd.Parameters.AddWithValue("@is_paid", isPaid);

                            transaksiId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string query2 = @"
                    INSERT INTO detailTransaksi 
                    (transaksi_id, produk_id, produk_nama, quantity, price, subtotal) 
                    VALUES (@transaksi_id, @produk_id, @produk_nama, @quantity, @price, @subtotal)";

                        foreach (var item in cartItems)
                        {
                            using (var cmd = new NpgsqlCommand(query2, conn))
                            {
                                cmd.Transaction = transaction;
                                cmd.Parameters.AddWithValue("@transaksi_id", transaksiId);
                                cmd.Parameters.AddWithValue("@produk_id", item.ProductId);
                                cmd.Parameters.AddWithValue("@produk_nama", item.NamaProduk);
                                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                                cmd.Parameters.AddWithValue("@price", (int)item.Harga);
                                cmd.Parameters.AddWithValue("@subtotal", (int)item.SubTotal);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}