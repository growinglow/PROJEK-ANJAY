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
            tblPembayaran.Location = new Point(237, 85);
            tblPembayaran.Name = "tblPembayaran";
            tblPembayaran.RowHeadersWidth = 62;
            tblPembayaran.Size = new Size(567, 305);
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
            btnRiwayatTransaksi.Location = new Point(46, 300);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(140, 34);
            btnRiwayatTransaksi.TabIndex = 1;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = true;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnProduk1
            // 
            btnProduk1.Location = new Point(46, 164);
            btnProduk1.Name = "btnProduk1";
            btnProduk1.Size = new Size(140, 34);
            btnProduk1.TabIndex = 2;
            btnProduk1.Text = "Produk";
            btnProduk1.UseVisualStyleBackColor = true;
            // 
            // btnPembayaran
            // 
            btnPembayaran.Location = new Point(46, 231);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(140, 34);
            btnPembayaran.TabIndex = 3;
            btnPembayaran.Text = "Pembayaran";
            btnPembayaran.UseVisualStyleBackColor = true;
            // 
            // btnLogout1
            // 
            btnLogout1.Location = new Point(46, 404);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.Size = new Size(140, 34);
            btnLogout1.TabIndex = 4;
            btnLogout1.Text = "Logout";
            btnLogout1.UseVisualStyleBackColor = true;
            btnLogout1.Click += btnLogout1_Click;
            // 
            // V_Pembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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