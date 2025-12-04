namespace PROJEK_ANJAY.View
{
    partial class V_StatusTransaksiAdm
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
            dgStatus = new DataGridView();
            tgl = new DataGridViewTextBoxColumn();
            usn = new DataGridViewTextBoxColumn();
            brg = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            statusskrg = new DataGridViewTextBoxColumn();
            lunas = new DataGridViewButtonColumn();
            proses = new DataGridViewButtonColumn();
            btnProduk = new Button();
            btnStatus = new Button();
            button1 = new Button();
            btnLaporan = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStatus).BeginInit();
            SuspendLayout();
            // 
            // dgStatus
            // 
            dgStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStatus.Columns.AddRange(new DataGridViewColumn[] { tgl, usn, brg, total, statusskrg, lunas, proses });
            dgStatus.Location = new Point(588, 203);
            dgStatus.Name = "dgStatus";
            dgStatus.ReadOnly = true;
            dgStatus.RowHeadersWidth = 62;
            dgStatus.Size = new Size(863, 662);
            dgStatus.TabIndex = 0;
            dgStatus.CellContentClick += dgStatus_CellContentClick;
            // 
            // tgl
            // 
            tgl.DataPropertyName = "TanggalFormated";
            tgl.HeaderText = "Tanggal";
            tgl.MinimumWidth = 8;
            tgl.Name = "tgl";
            tgl.ReadOnly = true;
            tgl.Width = 120;
            // 
            // usn
            // 
            usn.DataPropertyName = "Username";
            usn.HeaderText = "Username";
            usn.MinimumWidth = 8;
            usn.Name = "usn";
            usn.ReadOnly = true;
            usn.Width = 120;
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
            total.Width = 120;
            // 
            // statusskrg
            // 
            statusskrg.HeaderText = "Status skrg";
            statusskrg.MinimumWidth = 8;
            statusskrg.Name = "statusskrg";
            statusskrg.ReadOnly = true;
            statusskrg.Width = 150;
            // 
            // lunas
            // 
            lunas.HeaderText = "lunas";
            lunas.MinimumWidth = 8;
            lunas.Name = "lunas";
            lunas.ReadOnly = true;
            lunas.Text = "💵Lunas";
            lunas.UseColumnTextForButtonValue = true;
            lunas.Width = 70;
            // 
            // proses
            // 
            proses.HeaderText = "Proses";
            proses.MinimumWidth = 8;
            proses.Name = "proses";
            proses.ReadOnly = true;
            proses.Text = "🚗Otw";
            proses.UseColumnTextForButtonValue = true;
            proses.Width = 70;
            // 
            // btnProduk
            // 
            btnProduk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduk.ForeColor = Color.FromArgb(0, 64, 0);
            btnProduk.Location = new Point(79, 231);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(333, 62);
            btnProduk.TabIndex = 1;
            btnProduk.Text = "   Produk";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.UseVisualStyleBackColor = true;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.FromArgb(0, 64, 0);
            btnStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(79, 320);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(333, 64);
            btnStatus.TabIndex = 2;
            btnStatus.Text = "   Status Transaksi";
            btnStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnStatus.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(79, 413);
            button1.Name = "button1";
            button1.Size = new Size(333, 64);
            button1.TabIndex = 3;
            button1.Text = "   Riwayat Transaksi";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaporan.ForeColor = Color.FromArgb(0, 64, 0);
            btnLaporan.Location = new Point(79, 511);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(333, 61);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "   Laporan Penjualan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 64, 0);
            btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(197, 818);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 62);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // V_StatusTransaksiAdm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.STATUS_TRANSAKSI_ADMIN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(btnLogout);
            Controls.Add(btnLaporan);
            Controls.Add(button1);
            Controls.Add(btnStatus);
            Controls.Add(btnProduk);
            Controls.Add(dgStatus);
            DoubleBuffered = true;
            Name = "V_StatusTransaksiAdm";
            Text = "V_StatusTransaksiAdm";
            ((System.ComponentModel.ISupportInitialize)dgStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgStatus;
        private DataGridViewTextBoxColumn tgl;
        private DataGridViewTextBoxColumn usn;
        private DataGridViewTextBoxColumn brg;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn statusskrg;
        private DataGridViewButtonColumn lunas;
        private DataGridViewButtonColumn proses;
        private Button btnProduk;
        private Button btnStatus;
        private Button button1;
        private Button btnLaporan;
        private Button btnLogout;
    }
}