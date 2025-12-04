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
        private DbContext dbcon;
        public PayController()
        {
            dbcon = new DbContext();
        }

        public List<M_Pembayaran> GetTransaskiBlmByr(string username) //v_pembayaran pelanggan
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, status, created_at, alamat_pengiriman
                    FROM transaksi
                    WHERE username = @username AND status = 'BelumBayar' 
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
                                Status = reader.GetString("status"),
                                AlamatPengiriman = reader.IsDBNull("alamat_pengiriman") ? "" : reader.GetString("alamat_pengiriman"),
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


        public List<M_DetailBarang> GetDetailBarang(int transaksiId) // disini
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
        public bool BayarSekarang(int transaksiId)// disini
        {
            try
            {

                MessageBox.Show(
                              "Admin akan memverifikasi pembayaran Anda.\n" +
                              "Status akan berubah menjadi LUNAS setelah dikonfirmasi.",
                              "Sukses",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool SimpanTransaksi(string username, List<M_Keranjang> cartItems, string alamat) //disini juga v_pembayaran 
        {
            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query1 = @"
                    INSERT INTO transaksi (username, total, status, alamat_pengiriman) 
                    VALUES (@username, @total, @status, @alamat) 
                    RETURNING id"; 

                        int totalAmount = (int)cartItems.Sum(item => item.SubTotal); 

                        int transaksiId;
                        using (var cmd = new NpgsqlCommand(query1, conn))
                        {
                            cmd.Transaction = transaction; 
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@total", totalAmount);
                            cmd.Parameters.AddWithValue("@status", "BelumBayar");
                            cmd.Parameters.AddWithValue("@alamat", alamat ?? "");
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
        //public List<M_Pembayaran> GetTransaksiLunas()
        //{
        //    List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

        //    using (var conn = new NpgsqlConnection(dbcon.connStr))
        //    {
        //        conn.Open();
        //        string query = @"
        //        SELECT id, username, total, status, created_at , alamat_pengiriman
        //        FROM transaksi 
        //        WHERE status = 'Lunas'
        //        ORDER BY id ASC";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var transaksi = new M_Pembayaran
        //                    {
        //                        Id = reader.GetInt32("id"),
        //                        Username = reader.GetString("username"),
        //                        Total = (int)reader.GetDecimal("total"),
        //                        Status = reader.GetString("status"),
        //                        AlamatPengiriman = reader.IsDBNull("alamat_pengiriman") ? "" : reader.GetString("alamat_pengiriman"),
        //                        Tanggal = reader.GetDateTime("created_at")
        //                    };
        //                    transaksi.barang = GetDetailBarang(transaksi.Id);
        //                    listTransaksi.Add(transaksi);
        //                }
        //            }
        //        }
        //    }
        //    return listTransaksi;
        //}

        //public List<M_Pembayaran> GetTransaksiLunas(string username)
        //{
        //    List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

        //    using (var conn = new NpgsqlConnection(dbcon.connStr))
        //    {
        //        conn.Open();
        //        string query = @"
        //            SELECT id, username, total, status, created_at, alamat_pengiriman 
        //            FROM transaksi 
        //            WHERE status = 'Lunas' AND username = @username
        //            ORDER BY id ASC";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@username", username);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var transaksi = new M_Pembayaran
        //                    {
        //                        Id = reader.GetInt32("id"),
        //                        Username = reader.GetString("username"),
        //                        Total = (int)reader.GetDecimal("total"),
        //                        Status = reader.GetString("status"),
        //                        AlamatPengiriman = reader.IsDBNull("alamat_pengiriman") ? "" : reader.GetString("alamat_pengiriman"),
        //                        Tanggal = reader.GetDateTime("created_at")
        //                    };
        //                    transaksi.barang = GetDetailBarang(transaksi.Id);
        //                    listTransaksi.Add(transaksi);
        //                }
        //            }
        //        }
        //    }
        //    return listTransaksi;
        //}


        //public bool KonfirmPembayaran(int transactionId)
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(dbcon.connStr))
        //        {
        //            conn.Open();

        //            string getTransaksiQuery = "SELECT produk_id, quantity FROM detailtransaksi WHERE transaksi_id = @transaksi_id";
        //            List<(int productId, int quantity)> detailTransaksi = new List<(int, int)>();

        //            using (var cmd = new NpgsqlCommand(getTransaksiQuery, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@transaksi_id", transactionId);
        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        detailTransaksi.Add((reader.GetInt32(0), reader.GetInt32(1)));
        //                    }
        //                }
        //            }

        //            foreach (var (productId, quantity) in detailTransaksi)
        //            {
        //                string updateStockQuery = "UPDATE products SET stok = stok - @quantity WHERE id = @product_id AND stok >= @quantity";

        //                using (var cmd = new NpgsqlCommand(updateStockQuery, conn))
        //                {
        //                    cmd.Parameters.AddWithValue("@quantity", quantity);
        //                    cmd.Parameters.AddWithValue("@product_id", productId);

        //                    int rowsAffected = cmd.ExecuteNonQuery();
        //                    if (rowsAffected == 0)
        //                    {
        //                        MessageBox.Show($"Stok tidak mencukupi untuk produk ID: {productId}");
        //                        return false;
        //                    }
        //                }
        //            }

        //            string updateTransactionQuery = "UPDATE transaksi SET is_paid = true WHERE id = @transaksi_id";

        //            using (var cmd = new NpgsqlCommand(updateTransactionQuery, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@transaksi_id", transactionId);
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                if (rowsAffected > 0)
        //                {
        //                    MessageBox.Show("Pembayaran berhasil! Stok telah diperbarui.");
        //                    return true;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Gagal update status transaksi.");
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error during payment confirmation: {ex.Message}");
        //        return false;
        //    }
        //}
        // Di PayController.cs - Tambah method ini


        //public List<M_Pembayaran> GetTransSelese(string username) //riwayatcontroller
        //{
        //    List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

        //    using (var conn = new NpgsqlConnection(dbcon.connStr))
        //    {
        //        conn.Open();
        //        string query = @"
        //            SELECT id, username, total, status, created_at, alamat_pengiriman 
        //            FROM transaksi 
        //            WHERE status = 'Selesai' AND username = @username
        //            ORDER BY id ASC";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@username", username);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var transaksi = new M_Pembayaran
        //                    {
        //                        Id = reader.GetInt32("id"),
        //                        Username = reader.GetString("username"),
        //                        Total = (int)reader.GetDecimal("total"),
        //                        Status = reader.GetString("status"),
        //                        AlamatPengiriman = reader.IsDBNull("alamat_pengiriman") ? "" : reader.GetString("alamat_pengiriman"),
        //                        Tanggal = reader.GetDateTime("created_at")
        //                    };
        //                    transaksi.barang = GetDetailBarang(transaksi.Id);
        //                    listTransaksi.Add(transaksi);
        //                }
        //            }
        //        }
        //    }
        //    return listTransaksi;
        //}


        //public List<M_Pembayaran> GetTransSelese() //riwayatcontroller 
        //{
        //    List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

        //    using (var conn = new NpgsqlConnection(dbcon.connStr))
        //    {
        //        conn.Open();
        //        string query = @"
        //        SELECT id, username, total, status, created_at , alamat_pengiriman
        //        FROM transaksi 
        //        WHERE status = 'Selesai'
        //        ORDER BY id ASC";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var transaksi = new M_Pembayaran
        //                    {
        //                        Id = reader.GetInt32("id"),
        //                        Username = reader.GetString("username"),
        //                        Total = (int)reader.GetDecimal("total"),
        //                        Status = reader.GetString("status"),
        //                        AlamatPengiriman = reader.IsDBNull("alamat_pengiriman") ? "" : reader.GetString("alamat_pengiriman"),
        //                        Tanggal = reader.GetDateTime("created_at")
        //                    };
        //                    transaksi.barang = GetDetailBarang(transaksi.Id);
        //                    listTransaksi.Add(transaksi);
        //                }
        //            }
        //        }
        //    }
        //    return listTransaksi;
        //}
    }
}