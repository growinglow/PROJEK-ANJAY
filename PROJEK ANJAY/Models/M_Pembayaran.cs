using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Models
{
    public class M_Pembayaran
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Total { get; set; }
        public bool IsPaid { get; set; }
        public DateTime Tanggal { get; set; }
        public List<M_DetailBarang> barang { get; set; } = new List<M_DetailBarang>();

        public string Status => IsPaid ? "SUDAH BAYAR" : "BELUM BAYAR";
        public string TanggalFormatted => Tanggal.ToString("dd/MM/yyyy");
        public string TotalFormatted => $"Rp {Total:N0}";

        public string Barang
        {
            get
            {
                if (barang.Count == 0)
                    return "Tidak ada barang";

                return string.Join(" + ", barang.Select(item => $"{item.NamaProduk} ({item.Quantity})"));
            }
        }

    }
   
}
