namespace PROJEK_ANJAY.View
{
    partial class V_StatusTransaksiPlggn
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
            btnBayar = new Button();
            btnRiwayat = new Button();
            btnStatus = new Button();
            btnLogout = new Button();
            dgStatus = new DataGridView();
            tgl = new DataGridViewTextBoxColumn();
            brg = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            statusskrg = new DataGridViewTextBoxColumn();
            diterima = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgStatus).BeginInit();
            SuspendLayout();
            // 
            // btnProduk
            // 
            btnProduk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduk.ForeColor = Color.FromArgb(0, 64, 0);
            btnProduk.Location = new Point(77, 231);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(329, 59);
            btnProduk.TabIndex = 0;
            btnProduk.Text = "   Pembelian";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.UseVisualStyleBackColor = true;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnBayar
            // 
            btnBayar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = Color.FromArgb(0, 64, 0);
            btnBayar.Location = new Point(77, 320);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(329, 63);
            btnBayar.TabIndex = 1;
            btnBayar.Text = "   Pembayaran";
            btnBayar.TextAlign = ContentAlignment.MiddleLeft;
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = Color.FromArgb(0, 64, 0);
            btnRiwayat.Location = new Point(77, 421);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(329, 63);
            btnRiwayat.TabIndex = 2;
            btnRiwayat.Text = "   Riwayat Transaksi";
            btnRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.FromArgb(0, 64, 0);
            btnStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(77, 517);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(329, 63);
            btnStatus.TabIndex = 3;
            btnStatus.Text = "   Status Transaksi";
            btnStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnStatus.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 64, 0);
            btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(195, 819);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 59);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgStatus
            // 
            dgStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStatus.Columns.AddRange(new DataGridViewColumn[] { tgl, brg, total, alamat, statusskrg, diterima });
            dgStatus.Location = new Point(570, 205);
            dgStatus.Name = "dgStatus";
            dgStatus.ReadOnly = true;
            dgStatus.RowHeadersWidth = 62;
            dgStatus.Size = new Size(888, 616);
            dgStatus.TabIndex = 5;
            dgStatus.CellContentClick += dgStatus_CellContentClick;
            // 
            // tgl
            // 
            tgl.DataPropertyName = "TanggalFormatted";
            tgl.HeaderText = "Tanggal";
            tgl.MinimumWidth = 8;
            tgl.Name = "tgl";
            tgl.ReadOnly = true;
            tgl.Width = 120;
            // 
            // brg
            // 
            brg.DataPropertyName = "Barang";
            brg.HeaderText = "Barang";
            brg.MinimumWidth = 8;
            brg.Name = "brg";
            brg.ReadOnly = true;
            brg.Width = 150;
            // 
            // total
            // 
            total.DataPropertyName = "TotalFormatted";
            total.HeaderText = "Total";
            total.MinimumWidth = 8;
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 125;
            // 
            // alamat
            // 
            alamat.DataPropertyName = "AlamatPengiriman";
            alamat.HeaderText = "Alamat";
            alamat.MinimumWidth = 8;
            alamat.Name = "alamat";
            alamat.ReadOnly = true;
            alamat.Width = 150;
            // 
            // statusskrg
            // 
            statusskrg.DataPropertyName = "Status";
            statusskrg.HeaderText = "Status skrg";
            statusskrg.MinimumWidth = 8;
            statusskrg.Name = "statusskrg";
            statusskrg.ReadOnly = true;
            statusskrg.Width = 130;
            // 
            // diterima
            // 
            diterima.HeaderText = "Diterima";
            diterima.MinimumWidth = 8;
            diterima.Name = "diterima";
            diterima.ReadOnly = true;
            diterima.Text = "✅";
            diterima.UseColumnTextForButtonValue = true;
            diterima.Width = 150;
            // 
            // V_StatusTransaksiPlggn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.STATUS_TRANSAKSI_PELANGGAN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(dgStatus);
            Controls.Add(btnLogout);
            Controls.Add(btnStatus);
            Controls.Add(btnRiwayat);
            Controls.Add(btnBayar);
            Controls.Add(btnProduk);
            DoubleBuffered = true;
            Name = "V_StatusTransaksiPlggn";
            Text = "V_StatusTransaksiPlggn";
            ((System.ComponentModel.ISupportInitialize)dgStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduk;
        private Button btnBayar;
        private Button btnRiwayat;
        private Button btnStatus;
        private Button btnLogout;
        private DataGridView dgStatus;
        private DataGridViewTextBoxColumn tgl;
        private DataGridViewTextBoxColumn brg;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn statusskrg;
        private DataGridViewButtonColumn diterima;
    }
}