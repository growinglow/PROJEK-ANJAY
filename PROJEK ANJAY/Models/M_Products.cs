using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Models
{
    public class M_Products // nampung data produk
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; } 
        public string Deskripsi { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public bool IsActive { get; set; } 
    }
}
