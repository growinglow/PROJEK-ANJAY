namespace PROJEK_ANJAY.View
{
    partial class V_FormDashboard
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
            tblDashbord = new DataGridView();
            NamaProduk2 = new DataGridViewTextBoxColumn();
            Deskripsi2 = new DataGridViewTextBoxColumn();
            Harga2 = new DataGridViewTextBoxColumn();
            Stok2 = new DataGridViewTextBoxColumn();
            TambahQ = new DataGridViewButtonColumn();
            Qty = new DataGridViewTextBoxColumn();
            Kurangiplis = new DataGridViewButtonColumn();
            AddToCart = new DataGridViewButtonColumn();
            lblWelcome = new Label();
            LihatKeranjang = new Button();
            btnPembayaran = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)tblDashbord).BeginInit();
            SuspendLayout();
            // 
            // tblDashbord
            // 
            tblDashbord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblDashbord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDashbord.Columns.AddRange(new DataGridViewColumn[] { NamaProduk2, Deskripsi2, Harga2, Stok2, TambahQ, Qty, Kurangiplis, AddToCart });
            tblDashbord.Location = new Point(604, 196);
            tblDashbord.Name = "tblDashbord";
            tblDashbord.ReadOnly = true;
            tblDashbord.RowHeadersWidth = 62;
            tblDashbord.Size = new Size(813, 631);
            tblDashbord.TabIndex = 0;
            tblDashbord.CellContentClick += tblDashbord_CellContentClick;
            // 
            // NamaProduk2
            // 
            NamaProduk2.DataPropertyName = "NamaProduk";
            NamaProduk2.HeaderText = "Nama Produk";
            NamaProduk2.MinimumWidth = 8;
            NamaProduk2.Name = "NamaProduk2";
            NamaProduk2.ReadOnly = true;
            // 
            // Deskripsi2
            // 
            Deskripsi2.DataPropertyName = "Deskripsi";
            Deskripsi2.HeaderText = "Deskripsi";
            Deskripsi2.MinimumWidth = 8;
            Deskripsi2.Name = "Deskripsi2";
            Deskripsi2.ReadOnly = true;
            // 
            // Harga2
            // 
            Harga2.DataPropertyName = "Harga";
            Harga2.HeaderText = "Harga";
            Harga2.MinimumWidth = 8;
            Harga2.Name = "Harga2";
            Harga2.ReadOnly = true;
            // 
            // Stok2
            // 
            Stok2.DataPropertyName = "Stok";
            Stok2.HeaderText = "Stok";
            Stok2.MinimumWidth = 8;
            Stok2.Name = "Stok2";
            Stok2.ReadOnly = true;
            // 
            // TambahQ
            // 
            TambahQ.HeaderText = "Tambah";
            TambahQ.MinimumWidth = 8;
            TambahQ.Name = "TambahQ";
            TambahQ.ReadOnly = true;
            TambahQ.Text = "+";
            TambahQ.UseColumnTextForButtonValue = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantity";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Kurangiplis
            // 
            Kurangiplis.HeaderText = "Kurangi";
            Kurangiplis.MinimumWidth = 8;
            Kurangiplis.Name = "Kurangiplis";
            Kurangiplis.ReadOnly = true;
            Kurangiplis.Text = "-";
            Kurangiplis.UseColumnTextForButtonValue = true;
            // 
            // AddToCart
            // 
            AddToCart.HeaderText = "Tambah Ke Keranjang";
            AddToCart.MinimumWidth = 8;
            AddToCart.Name = "AddToCart";
            AddToCart.ReadOnly = true;
            AddToCart.Text = "tambah";
            AddToCart.UseColumnTextForButtonValue = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(200, 83);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 25);
            lblWelcome.TabIndex = 1;
            // 
            // LihatKeranjang
            // 
            LihatKeranjang.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LihatKeranjang.ForeColor = Color.FromArgb(0, 64, 0);
            LihatKeranjang.Location = new Point(1127, 843);
            LihatKeranjang.Name = "LihatKeranjang";
            LihatKeranjang.Size = new Size(290, 54);
            LihatKeranjang.TabIndex = 2;
            LihatKeranjang.Text = "Lihat Keranjang";
            LihatKeranjang.UseVisualStyleBackColor = true;
            LihatKeranjang.Click += LihatKeranjang_Click;
            // 
            // btnPembayaran
            // 
            btnPembayaran.BackColor = Color.Transparent;
            btnPembayaran.FlatStyle = FlatStyle.Flat;
            btnPembayaran.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPembayaran.ForeColor = Color.FromArgb(0, 64, 64);
            btnPembayaran.Location = new Point(80, 320);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(328, 62);
            btnPembayaran.TabIndex = 3;
            btnPembayaran.Text = "   Pembayaran";
            btnPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.UseVisualStyleBackColor = false;
            btnPembayaran.Click += btnPembayaran_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(78, 415);
            button1.Name = "button1";
            button1.Size = new Size(328, 59);
            button1.TabIndex = 4;
            button1.Text = "   Riwayat Transaksi";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 0);
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(196, 819);
            button2.Name = "button2";
            button2.Size = new Size(145, 59);
            button2.TabIndex = 5;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 0);
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(78, 232);
            button3.Name = "button3";
            button3.Size = new Size(328, 57);
            button3.TabIndex = 6;
            button3.Text = "   Pembelian";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            btnStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.FromArgb(0, 64, 0);
            btnStatus.Location = new Point(78, 504);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(328, 59);
            btnStatus.TabIndex = 7;
            btnStatus.Text = "   Status Transaksi";
            btnStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // V_FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PRODUK_PELANGGAN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(btnStatus);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPembayaran);
            Controls.Add(LihatKeranjang);
            Controls.Add(lblWelcome);
            Controls.Add(tblDashbord);
            DoubleBuffered = true;
            Name = "V_FormDashboard";
            Text = "V_FormDashboard";
            ((System.ComponentModel.ISupportInitialize)tblDashbord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblDashbord;
        private Label lblWelcome;
        private Button LihatKeranjang;
        private Button btnPembayaran;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn NamaProduk2;
        private DataGridViewTextBoxColumn Deskripsi2;
        private DataGridViewTextBoxColumn Harga2;
        private DataGridViewTextBoxColumn Stok2;
        private DataGridViewButtonColumn TambahQ;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewButtonColumn Kurangiplis;
        private DataGridViewButtonColumn AddToCart;
        private Button btnStatus;
    }
}