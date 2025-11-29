using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Controllers
{
    public abstract class Riwayat 
    {
        protected PayController payController;

        public Riwayat(PayController payController)
        {
            this.payController = payController;
        }

        public abstract List<M_Pembayaran> GetRiwayat();
    }
    public class RiwayatTransaksiController
    {
        private PayController payController;

        public RiwayatTransaksiController()
        {
            payController = new PayController();
        }

        // polymorphism, overriding method GetRiwayat() 
        public List<M_Pembayaran> GetRiwayat(string role, string username = "") 
        {
            Riwayat riwayat;

            if (role == "admin")
                riwayat = new RiwayatAdmin(payController); 
            else
                riwayat = new RiwayatPelanggan(payController, username); 

            return riwayat.GetRiwayat(); 
        }
    }
    public class RiwayatAdmin : Riwayat 
    {
        public RiwayatAdmin(PayController payController) : base(payController) { }

        public override List<M_Pembayaran> GetRiwayat()
        {
            return payController.GetTransaksiLunas();
        }
    }
    public class RiwayatPelanggan : Riwayat 
    {
        private string username;

        public RiwayatPelanggan(PayController payController, string username) : base(payController)
        {
            username = username;
        }
        public override List<M_Pembayaran> GetRiwayat()
        {
            return payController.GetTransaksiLunas(username);
        }
    }
}
