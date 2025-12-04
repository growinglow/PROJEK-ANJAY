namespace PROJEK_ANJAY.View
{
    partial class V_laporanPembayaran
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
            btnProduk = new Button();
            btnStatusTr = new Button();
            btnRiwayatTr = new Button();
            btnLaporanJual = new Button();
            btnLogout = new Button();
            dgLaporan = new DataGridView();
            TgglTrans = new DataGridViewTextBoxColumn();
            Usn = new DataGridViewTextBoxColumn();
            Barang = new DataGridViewTextBoxColumn();
            TotalTrans = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            cbTahun = new ComboBox();
            btnCari = new Button();
            lblTotalJual = new Label();
            ((System.ComponentModel.ISupportInitialize)dgLaporan).BeginInit();
            SuspendLayout();
            // 
            // btnProduk
            // 
            btnProduk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduk.ForeColor = Color.FromArgb(0, 64, 0);
            btnProduk.Location = new Point(79, 231);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(327, 58);
            btnProduk.TabIndex = 0;
            btnProduk.Text = "   Produk";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.UseVisualStyleBackColor = true;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnStatusTr
            // 
            btnStatusTr.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusTr.ForeColor = Color.FromArgb(0, 64, 0);
            btnStatusTr.Location = new Point(79, 328);
            btnStatusTr.Name = "btnStatusTr";
            btnStatusTr.Size = new Size(327, 58);
            btnStatusTr.TabIndex = 1;
            btnStatusTr.Text = "   Status Transaksi";
            btnStatusTr.TextAlign = ContentAlignment.MiddleLeft;
            btnStatusTr.UseVisualStyleBackColor = true;
            btnStatusTr.Click += btnStatusTr_Click;
            // 
            // btnRiwayatTr
            // 
            btnRiwayatTr.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTr.ForeColor = Color.FromArgb(0, 64, 0);
            btnRiwayatTr.Location = new Point(79, 428);
            btnRiwayatTr.Name = "btnRiwayatTr";
            btnRiwayatTr.Size = new Size(327, 64);
            btnRiwayatTr.TabIndex = 2;
            btnRiwayatTr.Text = "   Riwayat Transaksi";
            btnRiwayatTr.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTr.UseVisualStyleBackColor = true;
            btnRiwayatTr.Click += btnRiwayatTr_Click;
            // 
            // btnLaporanJual
            // 
            btnLaporanJual.BackColor = Color.FromArgb(0, 64, 0);
            btnLaporanJual.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaporanJual.ForeColor = Color.White;
            btnLaporanJual.Location = new Point(79, 518);
            btnLaporanJual.Name = "btnLaporanJual";
            btnLaporanJual.Size = new Size(327, 63);
            btnLaporanJual.TabIndex = 3;
            btnLaporanJual.Text = "   Laporan Penjualan";
            btnLaporanJual.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporanJual.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 64, 0);
            btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(195, 819);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 61);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgLaporan
            // 
            dgLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLaporan.Columns.AddRange(new DataGridViewColumn[] { TgglTrans, Usn, Barang, TotalTrans });
            dgLaporan.Location = new Point(627, 363);
            dgLaporan.Name = "dgLaporan";
            dgLaporan.ReadOnly = true;
            dgLaporan.RowHeadersWidth = 62;
            dgLaporan.Size = new Size(769, 358);
            dgLaporan.TabIndex = 5;
            // 
            // TgglTrans
            // 
            TgglTrans.DataPropertyName = "TanggalFormatted";
            TgglTrans.HeaderText = "Tanggal";
            TgglTrans.MinimumWidth = 8;
            TgglTrans.Name = "TgglTrans";
            TgglTrans.ReadOnly = true;
            TgglTrans.Width = 150;
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
            // Barang
            // 
            Barang.DataPropertyName = "Barang";
            Barang.HeaderText = "Barang";
            Barang.MinimumWidth = 8;
            Barang.Name = "Barang";
            Barang.ReadOnly = true;
            Barang.Width = 150;
            // 
            // TotalTrans
            // 
            TotalTrans.DataPropertyName = "TotalFormatted";
            TotalTrans.HeaderText = "Total";
            TotalTrans.MinimumWidth = 8;
            TotalTrans.Name = "TotalTrans";
            TotalTrans.ReadOnly = true;
            TotalTrans.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(799, 231);
            label1.Name = "label1";
            label1.Size = new Size(444, 38);
            label1.TabIndex = 6;
            label1.Text = "LAPORAN PENJUALAN SILONTAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(627, 312);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 7;
            label2.Text = "Pilih Tahun :";
            // 
            // cbTahun
            // 
            cbTahun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTahun.FormattingEnabled = true;
            cbTahun.Location = new Point(779, 309);
            cbTahun.Name = "cbTahun";
            cbTahun.Size = new Size(182, 40);
            cbTahun.TabIndex = 8;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(0, 64, 0);
            btnCari.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(983, 307);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(77, 41);
            btnCari.TabIndex = 9;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // lblTotalJual
            // 
            lblTotalJual.AutoSize = true;
            lblTotalJual.BackColor = Color.Transparent;
            lblTotalJual.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalJual.Location = new Point(627, 749);
            lblTotalJual.Name = "lblTotalJual";
            lblTotalJual.Size = new Size(24, 38);
            lblTotalJual.TabIndex = 10;
            lblTotalJual.Text = ".";
            // 
            // V_laporanPembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LAPORAN_PENJUALAN_ADMIN__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(lblTotalJual);
            Controls.Add(btnCari);
            Controls.Add(cbTahun);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgLaporan);
            Controls.Add(btnLogout);
            Controls.Add(btnLaporanJual);
            Controls.Add(btnRiwayatTr);
            Controls.Add(btnStatusTr);
            Controls.Add(btnProduk);
            DoubleBuffered = true;
            Name = "V_laporanPembayaran";
            Text = "V_laporanPembayaran";
            ((System.ComponentModel.ISupportInitialize)dgLaporan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProduk;
        private Button btnStatusTr;
        private Button btnRiwayatTr;
        private Button btnLaporanJual;
        private Button btnLogout;
        private DataGridView dgLaporan;
        private Label label1;
        private Label label2;
        private ComboBox cbTahun;
        private Button btnCari;
        private Label lblTotalJual;
        private DataGridViewTextBoxColumn TgglTrans;
        private DataGridViewTextBoxColumn Usn;
        private DataGridViewTextBoxColumn Barang;
        private DataGridViewTextBoxColumn TotalTrans;
    }
}