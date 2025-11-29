namespace PROJEK_ANJAY.View
{
    partial class V_Pembayaran
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
            tblPembayaran = new DataGridView();
            TglTransaksi = new DataGridViewTextBoxColumn();
            Barang = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            is_paid = new DataGridViewTextBoxColumn();
            BayarSkrg = new DataGridViewButtonColumn();
            btnRiwayatTransaksi = new Button();
            btnProduk1 = new Button();
            btnPembayaran = new Button();
            btnLogout1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tblPembayaran).BeginInit();
            SuspendLayout();
            // 
            // tblPembayaran
            // 
            tblPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblPembayaran.Columns.AddRange(new DataGridViewColumn[] { TglTransaksi, Barang, TotalHarga, is_paid, BayarSkrg });
            tblPembayaran.Location = new Point(615, 218);
            tblPembayaran.Name = "tblPembayaran";
            tblPembayaran.RowHeadersWidth = 62;
            tblPembayaran.Size = new Size(831, 660);
            tblPembayaran.TabIndex = 0;
            tblPembayaran.CellContentClick += tblPembayaran_CellContentClick;
            // 
            // TglTransaksi
            // 
            TglTransaksi.HeaderText = "Tanggal Transaksi";
            TglTransaksi.MinimumWidth = 8;
            TglTransaksi.Name = "TglTransaksi";
            TglTransaksi.Width = 150;
            // 
            // Barang
            // 
            Barang.HeaderText = "Barang";
            Barang.MinimumWidth = 8;
            Barang.Name = "Barang";
            Barang.Width = 150;
            // 
            // TotalHarga
            // 
            TotalHarga.HeaderText = "Total";
            TotalHarga.MinimumWidth = 8;
            TotalHarga.Name = "TotalHarga";
            TotalHarga.Width = 150;
            // 
            // is_paid
            // 
            is_paid.HeaderText = "Status";
            is_paid.MinimumWidth = 8;
            is_paid.Name = "is_paid";
            is_paid.Width = 150;
            // 
            // BayarSkrg
            // 
            BayarSkrg.HeaderText = "Bayar Sekarang";
            BayarSkrg.MinimumWidth = 8;
            BayarSkrg.Name = "BayarSkrg";
            BayarSkrg.Text = "Bayar";
            BayarSkrg.Width = 150;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = Color.FromArgb(0, 64, 0);
            btnRiwayatTransaksi.Location = new Point(82, 441);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(332, 65);
            btnRiwayatTransaksi.TabIndex = 1;
            btnRiwayatTransaksi.Text = "   Riwayat Transaksi";
            btnRiwayatTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTransaksi.UseVisualStyleBackColor = true;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnProduk1
            // 
            btnProduk1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduk1.ForeColor = Color.FromArgb(0, 64, 0);
            btnProduk1.Location = new Point(82, 249);
            btnProduk1.Name = "btnProduk1";
            btnProduk1.Size = new Size(332, 65);
            btnProduk1.TabIndex = 2;
            btnProduk1.Text = "   Produk";
            btnProduk1.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk1.UseVisualStyleBackColor = true;
            btnProduk1.Click += btnProduk1_Click;
            // 
            // btnPembayaran
            // 
            btnPembayaran.BackColor = Color.FromArgb(0, 64, 0);
            btnPembayaran.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPembayaran.ForeColor = Color.White;
            btnPembayaran.Location = new Point(80, 344);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(334, 65);
            btnPembayaran.TabIndex = 3;
            btnPembayaran.Text = "   Pembayaran";
            btnPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.UseVisualStyleBackColor = false;
            // 
            // btnLogout1
            // 
            btnLogout1.BackColor = Color.FromArgb(0, 64, 0);
            btnLogout1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout1.ForeColor = Color.White;
            btnLogout1.Location = new Point(200, 874);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.Size = new Size(147, 68);
            btnLogout1.TabIndex = 4;
            btnLogout1.Text = "Logout";
            btnLogout1.UseVisualStyleBackColor = false;
            btnLogout1.Click += btnLogout1_Click;
            // 
            // V_Pembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.STATUS_TRANSAKSI_PELANGGAN__1_;
            ClientSize = new Size(1490, 975);
            Controls.Add(btnLogout1);
            Controls.Add(btnPembayaran);
            Controls.Add(btnProduk1);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(tblPembayaran);
            Name = "V_Pembayaran";
            Text = "V_Pembayaran";
            Load += V_Pembayaran_Load;
            ((System.ComponentModel.ISupportInitialize)tblPembayaran).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tblPembayaran;
        private DataGridViewTextBoxColumn TglTransaksi;
        private DataGridViewTextBoxColumn Barang;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewTextBoxColumn is_paid;
        private DataGridViewButtonColumn BayarSkrg;
        private Button btnRiwayatTransaksi;
        private Button btnProduk1;
        private Button btnPembayaran;
        private Button btnLogout1;
    }
}