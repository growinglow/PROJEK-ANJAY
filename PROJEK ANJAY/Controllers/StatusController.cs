using Npgsql;
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
    public class StatusController
    {
        PayController payController;
        private DbContext dbcon;
        public StatusController()
        {
            dbcon = new DbContext();
        }
        public bool UpdateStatus(int transaksiId, string statusBaru) //statuscontroller
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbcon.connStr))
                {
                    conn.Open();

                    var validStatus = new List<string> { "BelumBayar", "Lunas", "Diproses", "Selesai" };
                    if (!validStatus.Contains(statusBaru))
                    {
                        MessageBox.Show($"Status '{statusBaru}' tidak valid!");
                        return false;
                    }

                    string query = "UPDATE transaksi SET status = @status WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", statusBaru);
                        cmd.Parameters.AddWithValue("@id", transaksiId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Opsional: Kalau status jadi "Lunas", kurangin stok
                            if (statusBaru == "Lunas")
                            {
                                KurangiStokSetelahKonfirmasi(transaksiId);
                            }

                            return true;
                        }
                        return false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error update status: {ex.Message}");
                return false;
            }
        }
        private void KurangiStokSetelahKonfirmasi(int transaksiId)// include statuscontroller
        {
            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string updateStokQuery = @"UPDATE products SET stok = stok - dt.quantity 
            FROM detailtransaksi dt 
            WHERE products.id = dt.produk_id 
            AND dt.transaksi_id = @transaksiId";

                using (var cmd = new NpgsqlCommand(updateStokQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@transaksiId", transaksiId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<M_Pembayaran> GetTransaksiUsn(string username)
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, status, created_at, alamat_pengiriman 
                    FROM transaksi 
                    WHERE status != 'Selesai' AND username = @username
                    ORDER BY id ASC";

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
        public List<M_Pembayaran> GetTransaksiblmselesai() //admin di statuscontroller
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, status, created_at, alamat_pengiriman
                    FROM transaksi
                    WHERE status != 'Selesai' 
                    ORDER BY created_at ASC";

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

    }
}
