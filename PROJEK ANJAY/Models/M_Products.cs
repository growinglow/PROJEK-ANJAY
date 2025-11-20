using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Models
{
    public class M_Products
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public string Deskripsi { get; set; }
        public double Harga { get; set; }
        public int Stok { get; set; }
    }
}
