using Npgsql;
using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.DataBase;
using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Controllers
{
    public class PayController
    {
        private string connectionString = "Your_PostgreSQL_Connection_String";
        private DbContext dbcon;
        public PayController()
        {
            dbcon = new DbContext();
        }
        public List<M_Pembayaran> GetTransaskiBlmByr(string username)
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, is_paid, created_at 
                    FROM transaksi
                    WHERE username = @username AND is_paid = false 
                    ORDER BY created_at ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transaksi = new M_Pembayaran
                            {
                                Id = reader.GetInt32("id"),
                                Username = reader.GetString("username"),
                                Total = (int)reader.GetDecimal("total"),
                                IsPaid = reader.GetBoolean("is_paid"),
                                Tanggal = reader.GetDateTime("created_at")
                            };
                            transaksi.barang = GetDetailBarang(transaksi.Id);
                            listTransaksi.Add(transaksi);
                        }
                    }
                }
            }
            return listTransaksi;
        }

        public List<M_Pembayaran> GetTransaksiLunas()
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                SELECT id, username, total, is_paid, created_at 
                FROM transaksi 
                WHERE is_paid = true
                ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transaksi = new M_Pembayaran
                            {
                                Id = reader.GetInt32("id"),
                                Username = reader.GetString("username"),
                                Total = (int)reader.GetDecimal("total"),
                                IsPaid = reader.GetBoolean("is_paid"),
                                Tanggal = reader.GetDateTime("created_at")
                            };
                            transaksi.barang = GetDetailBarang(transaksi.Id);
                            listTransaksi.Add(transaksi);
                        }
                    }
                }
            }
            return listTransaksi;
        }

        public List<M_Pembayaran> GetTransaksiLunas(string username)
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, is_paid, created_at 
                    FROM transaksi is_paid = true
                    ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transaksi = new M_Pembayaran
                            {
                                Id = reader.GetInt32("id"),
                                Username = reader.GetString("username"),
                                Total = (int)reader.GetDecimal("total"),
                                IsPaid = reader.GetBoolean("is_paid"),
                                Tanggal = reader.GetDateTime("created_at")
                            };
                            transaksi.barang = GetDetailBarang(transaksi.Id);
                            listTransaksi.Add(transaksi);
                        }
                    }
                }
            }
            return listTransaksi;
        }

        private List<M_DetailBarang> GetDetailBarang(int transaksiId)
        {
            var detailBarang = new List<M_DetailBarang>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = "SELECT produk_nama, quantity, price, subtotal FROM detailtransaksi WHERE transaksi_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", transaksiId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detailBarang.Add(new M_DetailBarang
                            {
                                NamaProduk = reader.GetString("produk_nama"),
                                Quantity = reader.GetInt32("quantity"),
                                Harga = (int)reader.GetDecimal("price"),
                                Subtotal = (int)reader.GetDecimal("subtotal")
                            });
                        }
                    }
                }
            }
            return detailBarang;
        }
        public bool BayarSekarang(int transaksiId)
        {
            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. UPDATE STOK dengan validasi
                        string updateStokQuery = @" UPDATE products SET stok = stok - dt.quantity FROM detailtransaksi dt 
                    WHERE products.id = dt.produk_id AND dt.transaksi_id = @transaksiId AND products.stok >= dt.quantity";

                        using (var cmdUpdateStok = new NpgsqlCommand(updateStokQuery, conn))
                        {
                            cmdUpdateStok.Transaction = transaction;
                            cmdUpdateStok.Parameters.AddWithValue("@transaksiId", transaksiId);
                            cmdUpdateStok.ExecuteNonQuery();
                        }

                        // 2. UPDATE STATUS TRANSAKSI
                        string updateStatusQuery = "UPDATE transaksi SET is_paid = true WHERE id = @id";
                        using (var cmdUpdateStatus = new NpgsqlCommand(updateStatusQuery, conn))
                        {
                            cmdUpdateStatus.Transaction = transaction;
                            cmdUpdateStatus.Parameters.AddWithValue("@id", transaksiId);
                            int statusUpdated = cmdUpdateStatus.ExecuteNonQuery();

                            if (statusUpdated > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Pembayaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                transaction.Rollback();
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public bool SimpanTransaksi(string username, List<M_Keranjang> cartItems, bool isPaid) // ini buat nyimpen data transaksi ke tabel transaksi dan detailtransaksi
        {//kenapa kok ada List<M_Keranjang> cartItems? soalnya kita perlu tau produk apa aja yg dibeli user beserta quantitynya, biar bisa dimasukin ke tabel detailtransaksi
            using (var conn = new NpgsqlConnection(dbcon.connStr))
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
                using (var conn = new NpgsqlConnection(dbcon.connStr))
                {
                    conn.Open();

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
                                MessageBox.Show($"Stok tidak mencukupi untuk produk ID: {productId}");
                                return false;
                            }
                        }
                    }

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
