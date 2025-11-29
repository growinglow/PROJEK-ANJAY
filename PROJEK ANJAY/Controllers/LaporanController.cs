using System;
using PROJEK_ANJAY.Models;
using PROJEK_ANJAY.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Controllers
{
    
    public class LaporanController
    {
        private PayController payController;
        public LaporanController()
        {
            payController = new PayController(); 
        }

        public (List<M_Pembayaran> data, string judul, int total) GenerateLaporan(string jenis, int? tahun = null)
        {
            var semuaTransaksi = payController.GetTransaksiLunas();

            List<M_Pembayaran> data;
            string judul;

            switch (jenis.ToLower())
            {
                case "tahunan" when tahun.HasValue:
                    data = semuaTransaksi.Where(t => t.Tanggal.Year == tahun.Value)
                                       .OrderByDescending(t => t.Id)
                                       .ToList();
                    judul = $"Tahun {tahun.Value}";
                    break;

                case "semua":
                default:
                    data = semuaTransaksi.OrderByDescending(t => t.Id).ToList();
                    judul = "Semua Transaksi";
                    break;
            }

            int total = data.Sum(t => t.Total);
            return (data, judul, total);
        }
    }
}
