using Npgsql;
using PROJEK_ANJAY.DataBase;
using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PROJEK_ANJAY.Controllers
{
    public class RiwayatTransaksiController
    {
        private DbContext dbcon;

        public RiwayatTransaksiController()
        {
            dbcon = new DbContext();
        }

        // Method overloading 1: Untuk pelanggan
        public List<M_Pembayaran> GetTransSelese(string username)
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, status, created_at, alamat_pengiriman 
                    FROM transaksi 
                    WHERE status = 'Selesai' AND username = @username
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

        // Method overloading 2: Untuk admin (semua)
        public List<M_Pembayaran> GetTransSelese()
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, status, created_at, alamat_pengiriman 
                    FROM transaksi 
                    WHERE status = 'Selesai'
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

        // Helper method
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
    }
}