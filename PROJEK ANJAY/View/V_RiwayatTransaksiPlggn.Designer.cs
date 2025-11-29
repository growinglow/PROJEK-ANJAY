namespace PROJEK_ANJAY.View
{
    partial class V_RiwayatTransaksiPlggn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) // ini adalah method Dispose, fungsinya buat bersihin resource yang udah ga dipake lagi. misal pas form ditutup, maka resource yang dipake form itu harus dibersihin supaya ga makan memori terus-menerus
        {
            if (disposing && (components != null)) // kalo disposing itu true dan components ga null, maka komponen-komponen di form itu dibersihin
            {
                components.Dispose();
            }
            base.Dispose(disposing); // trus panggil method Dispose di base class (yaitu Form) buat bersihin resource yang dipake sama Form
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblRiwayatPlgn = new DataGridView();
            TglTransaksi = new DataGridViewTextBoxColumn();
            Barang = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnProduk = new Button();
            btnBayar = new Button();
            btnRiwayatTr = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tblRiwayatPlgn).BeginInit();
            SuspendLayout();
            // 
            // tblRiwayatPlgn
            // 
            tblRiwayatPlgn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblRiwayatPlgn.Columns.AddRange(new DataGridViewColumn[] { TglTransaksi, Barang, Total });
            tblRiwayatPlgn.Location = new Point(605, 200);
            tblRiwayatPlgn.Name = "tblRiwayatPlgn";
            tblRiwayatPlgn.RowHeadersWidth = 62;
            tblRiwayatPlgn.Size = new Size(812, 621);
            tblRiwayatPlgn.TabIndex = 0;
            // 
            // TglTransaksi
            // 
            TglTransaksi.DataPropertyName = "Tanggal";
            TglTransaksi.HeaderText = "Tanggal Transaksi";
            TglTransaksi.MinimumWidth = 8;
            TglTransaksi.Name = "TglTransaksi";
            TglTransaksi.Width = 150;
            // 
            // Barang
            // 
            Barang.DataPropertyName = "Barang";
            Barang.HeaderText = "Barang (Qty)";
            Barang.MinimumWidth = 8;
            Barang.Name = "Barang";
            Barang.Width = 150;
            // 
            // Total
            // 
            Total.DataPropertyName = "TotalFormatted";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.Width = 150;
            // 
            // btnProduk
            // 
            btnProduk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduk.ForeColor = Color.FromArgb(0, 64, 0);
            btnProduk.Location = new Point(79, 233);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(325, 61);
            btnProduk.TabIndex = 1;
            btnProduk.Text = "   Produk";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.UseVisualStyleBackColor = true;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = SystemColors.Control;
            btnBayar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = Color.FromArgb(0, 64, 0);
            btnBayar.Location = new Point(79, 319);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(325, 64);
            btnBayar.TabIndex = 2;
            btnBayar.Text = "   Pembayaran";
            btnBayar.TextAlign = ContentAlignment.MiddleLeft;
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // btnRiwayatTr
            // 
            btnRiwayatTr.BackColor = Color.FromArgb(0, 64, 0);
            btnRiwayatTr.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTr.ForeColor = Color.White;
            btnRiwayatTr.Location = new Point(79, 412);
            btnRiwayatTr.Name = "btnRiwayatTr";
            btnRiwayatTr.Size = new Size(325, 60);
            btnRiwayatTr.TabIndex = 3;
            btnRiwayatTr.Text = "   Riwayat Transaksi";
            btnRiwayatTr.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTr.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(196, 819);
            button1.Name = "button1";
            button1.Size = new Size(149, 59);
            button1.TabIndex = 4;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // V_RiwayatTransaksiPlggn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RIWAYAT_TRANSAKSI_PELANGGAN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(button1);
            Controls.Add(btnRiwayatTr);
            Controls.Add(btnBayar);
            Controls.Add(btnProduk);
            Controls.Add(tblRiwayatPlgn);
            DoubleBuffered = true;
            Name = "V_RiwayatTransaksiPlggn";
            Text = "V_RiwayatTransaksiPlggn";
            ((System.ComponentModel.ISupportInitialize)tblRiwayatPlgn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tblRiwayatPlgn;
        private DataGridViewTextBoxColumn TglTransaksi;
        private DataGridViewTextBoxColumn Barang;
        private DataGridViewTextBoxColumn Total;
        private Button btnProduk;
        private Button btnBayar;
        private Button btnRiwayatTr;
        private Button button1;
    }
}