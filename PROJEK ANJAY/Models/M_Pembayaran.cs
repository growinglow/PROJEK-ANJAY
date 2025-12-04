// Di M_Pembayaran.cs
using PROJEK_ANJAY.Models;

public class M_Pembayaran
{
    public int Id { get; set; }
    public string Username { get; set; }
    public int Total { get; set; }
    public string Status { get; set; }
    public DateTime Tanggal { get; set; }
    public string AlamatPengiriman { get; set; }
    public List<M_DetailBarang> barang { get; set; } = new List<M_DetailBarang>();

    // Property format
    public string TanggalFormatted => Tanggal.ToString("dd/MM/yyyy");
    public string TotalFormatted => $"Rp {Total:N0}";

    public string Barang
    {
        get
        {
            if (barang.Count == 0) return "Tidak ada barang";
            return string.Join(" + ", barang.Select(item => $"{item.NamaProduk} ({item.Quantity})"));
        }
    }

    // Property untuk tampilan status
    public string StatusDisplay
    {
        get
        {
            return Status switch
            {
                "BelumBayar" => "BELUM BAYAR",
                "Lunas" => "LUNAS",
                "Diproses" => "DIPROSES",
                "Selesai" => "SELESAI",
                _ => "BELUM BAYAR"
            };
        }
    }

    // Property untuk warna status (optional)
    public Color StatusColor
    {
        get
        {
            return Status switch
            {
                "BelumBayar" => Color.Red,
                "Lunas" => Color.Orange,
                "Diproses" => Color.Blue,
                "Selesai" => Color.Green,
                _ => Color.Red
            };
        }
    }
}