using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Models
{
    public class M_Keranjang
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int ProductId { get; set; }
        public string NamaProduk { get; set; }
        public double Harga { get; set; }
        public int Quantity { get; set; }

        public double SubTotal
        {
            get { return Harga * Quantity; }
        }
    }
}
