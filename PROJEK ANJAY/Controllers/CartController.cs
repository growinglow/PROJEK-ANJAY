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
        private DbContext context;

        public CartController()
        {
            context = new DbContext();
        }

        public virtual bool AddToCart(string username, int productId, int quantity)
        {
            using (var conn = new NpgsqlConnection(context.connStr))
            {
                conn.Open();

                string cekQuery = "SELECT quantity FROM cart WHERE username = @username AND product_id = @product_id";
                using (var checkCmd = new NpgsqlCommand(cekQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@product_id", productId);

                    var existingQuantity = checkCmd.ExecuteScalar();

                    if (existingQuantity != null)
                    {
                        string updateQuery = "UPDATE cart SET quantity = quantity + @quantity WHERE username = @username AND product_id = @product_id"; // kalo ini buat update quantitynya, jadi quantitynya ditambahin sesuai jumlah yang diinginkan user. casenya gini misal user udah punya produk A di keranjang sebanyak 2, trs dia nambahin lagi 3, maka di query ini quantitynya jadi quantity + 3, jadinya totalnya 5. bedanya sama kode sebelumnya yang string cekQuery adalah kita cuma ngecek doang, kalo ini kita ngupdate quantitynya
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
                        string insertQuery = "INSERT INTO cart (username, product_id, quantity) VALUES (@username, @product_id, @quantity)"; // kalo ini buat nambahin produk baru ke keranjang, jadi kalo misal produk gaada di keranjang, maka kita masukin produk baru ke tabel cart dengan quantity sesuai yang diinginkan user
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

        public virtual List<M_Keranjang> GetItemKeranjang(string username)
        {
            List<M_Keranjang> keranjangItems = new List<M_Keranjang>();
            using (var conn = new NpgsqlConnection(context.connStr))
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

        public virtual bool ClearKeranjang(string username) // kenapa string username? soalnya kita mau ngapus data keranjang milik user yg lagi login doang
        {
            using (var conn = new NpgsqlConnection(context.connStr)) // maksud var conn = new Npg tuh buat bikin koneksi ke database postgres
            {
                conn.Open();
                string query = "DELETE FROM cart WHERE username = @username"; // ini tuh kalo ada cases misal user udah checkout, trs keranjangnya bakal dikosongin. jadi di database cart akan dihapus semua data keranjang milik user yg lagi login soalnya dia udah cekout

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username); // kalo misal tanya kenapa di delete tapi perlu parameter id? soalnya kita mau ngapus data keranjang milik user yg lagi login doang, biar ga ngapus data keranjang milik user lain
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool UpdateCartItem(int cartId, int quantity) // nah ini kenapa butuh int cartId? soalnya kita mau update data keranjang berdasarkan id keranjang, biar ga salah update. contohnya gini misal user punya 2 produk di keranjang, trs dia mau update quantity produk A, maka kita perlu tau dulu id keranjang produk A itu berapa, biar kita bisa update quantitynya sesuai id keranjang
        {
            using (var conn = new NpgsqlConnection(context.connStr))
            {
                conn.Open();
                string query = "UPDATE cart SET quantity = @quantity WHERE id = @id"; // nah di atas itu buat update quantity di tabel cart berdasarkan id keranjang

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity); // ngisi placeholdernya soalnya kita pake parameterized query biar aman dari SQL Injection, soalnya sql injection tuh bahaya banget kalo sampe terjadi, cara kerja dia itu misal user iseng masukin kode sql di inputan quantity, misal dia masukin "0; DROP TABLE cart;", maka kalo kita langsung masukin ke query tanpa di-parameterize, maka querynya bakal jadi "UPDATE cart SET quantity = 0; DROP TABLE cart; WHERE id = @id", nah ini bahaya banget soalnya tabel cart bakal kehapus. makanya kita pake parameterized query biar inputan user ga langsung dimasukin ke query, tapi di-handle dulu sama database driver
                    cmd.Parameters.AddWithValue("@id", cartId); // ngisi placeholdernya, dia cara kerjanya sama kayak yg di atas
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool RemoveFromCart(int cartId)
        {
            using (var conn = new NpgsqlConnection(context.connStr))
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
        //public bool UpdateStokProduk(int productId, int quantitySold)
        //{
        //    using (var conn = new NpgsqlConnection(context.connStr))
        //    {
        //        conn.Open();
        //        string query = "UPDATE products SET stok = stok - @quantity WHERE id = @product_id AND stok >= @quantity";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@quantity", quantitySold);
        //            cmd.Parameters.AddWithValue("@product_id", productId);

        //            return cmd.ExecuteNonQuery() > 0;
        //        }
        //    }
        //}
        public bool SimpanTransaksi(string username, List<M_Keranjang> cartItems, bool isPaid) // ini buat nyimpen data transaksi ke tabel transaksi dan detailtransaksi
        {//kenapa kok ada List<M_Keranjang> cartItems? soalnya kita perlu tau produk apa aja yg dibeli user beserta quantitynya, biar bisa dimasukin ke tabel detailtransaksi
            using (var conn = new NpgsqlConnection(context.connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction()) // pake transaction biar kalo ada error di tengah proses, semua perubahan di database bisa di-rollback, jadi data tetep konsisten. maksudnya gini, misal pas nyimpen data transaksi ke tabel transaksi sukses, tapi pas nyimpen data ke tabel detailtransaksi gagal, maka kita ga mau data transaksi tetep masuk ke database, soalnya kalo sampe masuk, data di database jadi ga konsisten. makanya kita pake transaction biar kalo ada error, semua perubahan di database bisa dibatalin
                {
                    try // coba nyimpen data transaksi dan detailtransaksi
                    {
                        string query1 = @"
                    INSERT INTO transaksi (username, total, is_paid) 
                    VALUES (@username, @total, @is_paid) 
                    RETURNING id"; // kenapa ada returning id? soalnya kita perlu tau id transaksi yg baru aja dibuat, biar bisa dipake buat masukin data ke tabel detailtransaksi

                        int totalAmount = (int)cartItems.Sum(item => item.SubTotal); // hitung total amount dari semua item di keranjang, cara kerjanya itu kita nge-sum subtotal dari tiap item di keranjang. misal ada 2 item di keranjang, item A subtotalnya 10000, item B subtotalnya 20000, maka totalAmountnya jadi 30000

                        int transaksiId; // ini buat nampung id transaksi yg baru aja dibuat
                        using (var cmd = new NpgsqlCommand(query1, conn))
                        {
                            cmd.Transaction = transaction; // kaitin command ini ke transaction biar kalo ada error, perubahan di database bisa di-rollback. apa itu rollback? rollback itu artinya membatalkan semua perubahan di database yg udah dilakukan di dalam transaction. maksudnya gini, misal pas nyimpen data transaksi ke tabel transaksi sukses, tapi pas nyimpen data ke tabel detailtransaksi gagal, maka kita ga mau data transaksi tetep masuk ke database, soalnya kalo sampe masuk, data di database jadi ga konsisten. makanya kita pake transaction biar kalo ada error, semua perubahan di database bisa dibatalin
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@total", totalAmount);
                            cmd.Parameters.AddWithValue("@is_paid", isPaid);

                            transaksiId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string query2 = @"
                    INSERT INTO detailTransaksi 
                    (transaksi_id, produk_id, produk_nama, quantity, price, subtotal) 
                    VALUES (@transaksi_id, @produk_id, @produk_nama, @quantity, @price, @subtotal)"; // ini buat masukin data ke tabel detailtransaksi

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

                        transaction.Commit(); // kalo semua proses di atas sukses, maka perubahan di database di-commit, artinya semua perubahan di database disimpan permanen
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback(); // kalo ada error di tengah proses, maka semua perubahan di database di-rollback, artinya semua perubahan di database dibatalin
                        throw;
                    }
                }
            }
        }
        public bool KonfirmPembayaran(int transactionId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(context.connStr))
                {
                    conn.Open();

                    // 1. Dapatkan detail transaksi
                    string getTransaksiQuery = "SELECT produk_id, quantity FROM detailtransaksi WHERE transaksi_id = @transaksi_id";
                    List<(int productId, int quantity)> detailTransaksi = new List<(int, int)>();

                    using (var cmd = new NpgsqlCommand(getTransaksiQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@transaksi_id", transactionId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                detailTransaksi.Add((reader.GetInt32(0), reader.GetInt32(1)));
                            }
                        }
                    }

                    foreach (var (productId, quantity) in detailTransaksi)
                    {
                        string updateStockQuery = "UPDATE products SET stok = stok - @quantity WHERE id = @product_id AND stok >= @quantity";

                        using (var cmd = new NpgsqlCommand(updateStockQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@product_id", productId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                // Stok tidak mencukupi
                                MessageBox.Show($"Stok tidak mencukupi untuk produk ID: {productId}");
                                return false;
                            }
                        }
                    }

                    // 3. Update status transaksi menjadi SUDAH BAYAR
                    string updateTransactionQuery = "UPDATE transaksi SET is_paid = true WHERE id = @transaksi_id";

                    using (var cmd = new NpgsqlCommand(updateTransactionQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@transaksi_id", transactionId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pembayaran berhasil! Stok telah diperbarui.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Gagal update status transaksi.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during payment confirmation: {ex.Message}");
                return false;
            }
        }
    }
}

