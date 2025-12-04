namespace PROJEK_ANJAY.View
{
    partial class V_RiwayatTransaksiAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblRiwayatAdm = new DataGridView();
            IdTransaksi = new DataGridViewTextBoxColumn();
            Usn = new DataGridViewTextBoxColumn();
            TglTransaksi = new DataGridViewTextBoxColumn();
            Barang = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnProduk = new Button();
            button2 = new Button();
            btnRiwayatTr = new Button();
            BtnLapPenjualan = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)tblRiwayatAdm).BeginInit();
            SuspendLayout();
            // 
            // tblRiwayatAdm
            // 
            tblRiwayatAdm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblRiwayatAdm.Columns.AddRange(new DataGridViewColumn[] { IdTransaksi, Usn, TglTransaksi, Barang, Total });
            tblRiwayatAdm.Location = new Point(604, 203);
            tblRiwayatAdm.Name = "tblRiwayatAdm";
            tblRiwayatAdm.ReadOnly = true;
            tblRiwayatAdm.RowHeadersWidth = 62;
            tblRiwayatAdm.Size = new Size(840, 625);
            tblRiwayatAdm.TabIndex = 0;
            // 
            // IdTransaksi
            // 
            IdTransaksi.DataPropertyName = "Id";
            IdTransaksi.HeaderText = "Id Transaksi";
            IdTransaksi.MinimumWidth = 8;
            IdTransaksi.Name = "IdTransaksi";
            IdTransaksi.ReadOnly = true;
            IdTransaksi.Width = 150;
            // 
            // Usn
            // 
            Usn.DataPropertyName = "Username";
            Usn.HeaderText = "Username";
            Usn.MinimumWidth = 8;
            Usn.Name = "Usn";
            Usn.ReadOnly = true;
            Usn.Width = 150;
            // 
            // TglTransaksi
            // 
            TglTransaksi.DataPropertyName = "TanggalFormatted";
            TglTransaksi.HeaderText = "Tanggal Transaksi";
            TglTransaksi.MinimumWidth = 8;
            TglTransaksi.Name = "TglTransaksi";
            TglTransaksi.ReadOnly = true;
            TglTransaksi.Width = 150;
            // 
            // Barang
            // 
            Barang.DataPropertyName = "Barang";
            Barang.HeaderText = "Barang Qty";
            Barang.MinimumWidth = 8;
            Barang.Name = "Barang";
            Barang.ReadOnly = true;
            Barang.Width = 150;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
            // 
            // btnProduk
            // 
            btnProduk.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduk.ForeColor = Color.FromArgb(0, 64, 0);
            btnProduk.Location = new Point(80, 234);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(328, 59);
            btnProduk.TabIndex = 1;
            btnProduk.Text = "   Produk";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.UseVisualStyleBackColor = true;
            btnProduk.Click += btnProduk_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(80, 329);
            button2.Name = "button2";
            button2.Size = new Size(328, 58);
            button2.TabIndex = 2;
            button2.Text = "   Status Transaksi";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnRiwayatTr
            // 
            btnRiwayatTr.BackColor = Color.FromArgb(0, 64, 0);
            btnRiwayatTr.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTr.ForeColor = Color.White;
            btnRiwayatTr.Location = new Point(79, 427);
            btnRiwayatTr.Name = "btnRiwayatTr";
            btnRiwayatTr.Size = new Size(328, 62);
            btnRiwayatTr.TabIndex = 3;
            btnRiwayatTr.Text = "   Riwayat Transaksi";
            btnRiwayatTr.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTr.UseVisualStyleBackColor = false;
            // 
            // BtnLapPenjualan
            // 
            BtnLapPenjualan.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLapPenjualan.ForeColor = Color.FromArgb(0, 64, 0);
            BtnLapPenjualan.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLapPenjualan.Location = new Point(76, 517);
            BtnLapPenjualan.Name = "BtnLapPenjualan";
            BtnLapPenjualan.Size = new Size(335, 60);
            BtnLapPenjualan.TabIndex = 4;
            BtnLapPenjualan.Text = " Laporan Penjualan";
            BtnLapPenjualan.UseVisualStyleBackColor = true;
            BtnLapPenjualan.Click += BtnLapPenjualan_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 64, 0);
            btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(196, 820);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 60);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // V_RiwayatTransaksiAdm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RIWAYAT_TRANSAKSI_ADMIN__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(btnLogout);
            Controls.Add(BtnLapPenjualan);
            Controls.Add(btnRiwayatTr);
            Controls.Add(button2);
            Controls.Add(btnProduk);
            Controls.Add(tblRiwayatAdm);
            DoubleBuffered = true;
            Name = "V_RiwayatTransaksiAdm";
            Text = "V_RiwayatTransaksiAdm";
            ((System.ComponentModel.ISupportInitialize)tblRiwayatAdm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tblRiwayatAdm;
        private Button btnProduk;
        private Button button2;
        private Button btnRiwayatTr;
        private Button BtnLapPenjualan;
        private Button btnLogout;
        private DataGridViewTextBoxColumn IdTransaksi;
        private DataGridViewTextBoxColumn Usn;
        private DataGridViewTextBoxColumn TglTransaksi;
        private DataGridViewTextBoxColumn Barang;
        private DataGridViewTextBoxColumn Total;
    }
}