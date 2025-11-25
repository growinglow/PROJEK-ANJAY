using PROJEK_ANJAY.Controllers;
using PROJEK_ANJAY.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROJEK_ANJAY.View
{
    public partial class V_RiwayatTransaksi : Form
    {
        private string usn;
        private DataGridView dataGridView1;
        private bool _isAdmin;
        private Label lblInfo;

        // ✅ OOP: Constructor Overloading
        public V_RiwayatTransaksi(string username) : this(username, "") { }

        public V_RiwayatTransaksi(string username, string password = "")
        {
            usn = username;
            _isAdmin = CekAdmin(username, password);

            InitializeComponent();
            CreateDataGridView();
            SetupGridView();
            LoadRiwayat();
        }

        // ✅ ENKAPSULASI: Private method untuk cek role
        private bool CekAdmin(string username, string password)
        {
            return (username == "admin" && password == "admin#123");
        }

        private void InitializeComponent()
        {
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(313, 61);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(428, 30);
            lblInfo.TabIndex = 0;
            // 
            // V_RiwayatTransaksi
            // 
            BackgroundImage = Properties.Resources.RIWAYAT_TRANSAKSI_PELANGGAN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 444);
            Controls.Add(lblInfo);
            DoubleBuffered = true;
            Name = "V_RiwayatTransaksi";
            Text = "Riwayat Transaksi";
            ResumeLayout(false);
        }

        private void CreateDataGridView()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Location = new Point(50, 50);
            dataGridView1.Size = new Size(700, 400);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(dataGridView1);
        }

        // ✅ INHERITANCE + POLYMORPHISM + OVERRIDING
        public abstract class BaseRiwayatHandler
        {
            public abstract void SetupGrid(DataGridView grid);
            public abstract void AddRow(DataGridView grid, M_Pembayaran transaksi);
            public abstract string GetTitle(string username);
            public abstract string GetInfoText(string username, int count);
        }

        public class AdminHandler : BaseRiwayatHandler
        {
            // ✅ OVERRIDING
            public override void SetupGrid(DataGridView grid)
            {
                grid.Columns.Clear();
                grid.AutoGenerateColumns = false;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                grid.Columns.Add("klmTanggal", "Tanggal");
                grid.Columns.Add("klmBarang", "Barang");
                grid.Columns.Add("klmTotal", "Total");
                grid.Columns.Add("klmStatus", "Status");
                grid.Columns.Add("klmUser", "Username");
            }

            // ✅ OVERRIDING  
            public override void AddRow(DataGridView grid, M_Pembayaran transaksi)
            {
                grid.Rows.Add(
                    transaksi.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                    transaksi.Barang,
                    $"Rp {transaksi.Total:N0}",
                    "✅ LUNAS",
                    transaksi.Username
                );
            }

            public override string GetTitle(string username) => "Riwayat Transaksi - ADMIN MODE";
            public override string GetInfoText(string username, int count) => $"Semua transaksi sudah bayar ({count} data)";
        }

        public class UserHandler : BaseRiwayatHandler
        {
            // ✅ OVERRIDING
            public override void SetupGrid(DataGridView grid)
            {
                grid.Columns.Clear();
                grid.AutoGenerateColumns = false;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                grid.Columns.Add("klmTanggal", "Tanggal");
                grid.Columns.Add("klmBarang", "Barang");
                grid.Columns.Add("klmTotal", "Total");
                grid.Columns.Add("klmStatus", "Status");
            }

            // ✅ OVERRIDING
            public override void AddRow(DataGridView grid, M_Pembayaran transaksi)
            {
                grid.Rows.Add(
                    transaksi.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                    transaksi.Barang,
                    $"Rp {transaksi.Total:N0}",
                    "LUNAS"
                );
            }

            public override string GetTitle(string username) => $"Riwayat Transaksi {username}";
            public override string GetInfoText(string username, int count) => $"Riwayat {username} ({count} data)";
        }

        // ✅ POLYMORPHISM: Method menggunakan base class type
        private BaseRiwayatHandler GetHandler()
        {
            return _isAdmin ? (BaseRiwayatHandler)new AdminHandler() : new UserHandler();
        }

        private void SetupGridView()
        {
            var handler = GetHandler(); // ✅ POLYMORPHISM
            handler.SetupGrid(dataGridView1);
            this.Text = handler.GetTitle(usn);
        }

        private void LoadRiwayat()
        {
            var payController = new PayController();
            var semuaTransaksi = payController.GetSemuaTransaksi();

            // ✅ FILTER: Hanya yang SUDAH BAYAR
            var transaksiSudahBayar = semuaTransaksi.Where(t => t.IsPaid).ToList();

            var filteredTransaksi = _isAdmin
                ? transaksiSudahBayar
                : transaksiSudahBayar.Where(t => t.Username == usn).ToList();

            dataGridView1.Rows.Clear();

            var handler = GetHandler(); // ✅ POLYMORPHISM

            foreach (var trans in filteredTransaksi.OrderByDescending(t => t.Tanggal))
            {
                handler.AddRow(dataGridView1, trans); // ✅ POLYMORPHISM
            }

            // ✅ Update info text menggunakan handler
            lblInfo.Text = handler.GetInfoText(usn, filteredTransaksi.Count);
        }
    }
}