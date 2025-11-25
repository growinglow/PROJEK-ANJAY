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
                    ORDER BY created_at DESC";

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
        public List<M_Pembayaran> GetSemuaTransaksi()
        {
            List<M_Pembayaran> listTransaksi = new List<M_Pembayaran>();

            using (var conn = new NpgsqlConnection(dbcon.connStr))
            {
                conn.Open();
                string query = @"
                    SELECT id, username, total, is_paid, created_at 
                    FROM transaksi 
                    ORDER BY created_at DESC";

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
                string query = "UPDATE transaksi SET is_paid = true WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", transaksiId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
