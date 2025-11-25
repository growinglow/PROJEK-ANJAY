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
            ((System.ComponentModel.ISupportInitialize)tblDashbord).BeginInit();
            SuspendLayout();
            // 
            // tblDashbord
            // 
            tblDashbord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblDashbord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDashbord.Columns.AddRange(new DataGridViewColumn[] { NamaProduk2, Deskripsi2, Harga2, Stok2, TambahQ, Qty, Kurangiplis, AddToCart });
            tblDashbord.Location = new Point(436, 99);
            tblDashbord.Name = "tblDashbord";
            tblDashbord.RowHeadersWidth = 62;
            tblDashbord.Size = new Size(669, 416);
            tblDashbord.TabIndex = 0;
            tblDashbord.CellContentClick += tblDashbord_CellContentClick;
            // 
            // NamaProduk2
            // 
            NamaProduk2.DataPropertyName = "NamaProduk";
            NamaProduk2.HeaderText = "Nama Produk";
            NamaProduk2.MinimumWidth = 8;
            NamaProduk2.Name = "NamaProduk2";
            // 
            // Deskripsi2
            // 
            Deskripsi2.DataPropertyName = "Deskripsi";
            Deskripsi2.HeaderText = "Deskripsi";
            Deskripsi2.MinimumWidth = 8;
            Deskripsi2.Name = "Deskripsi2";
            // 
            // Harga2
            // 
            Harga2.DataPropertyName = "Harga";
            Harga2.HeaderText = "Harga";
            Harga2.MinimumWidth = 8;
            Harga2.Name = "Harga2";
            // 
            // Stok2
            // 
            Stok2.DataPropertyName = "Stok";
            Stok2.HeaderText = "Stok";
            Stok2.MinimumWidth = 8;
            Stok2.Name = "Stok2";
            // 
            // TambahQ
            // 
            TambahQ.HeaderText = "Tambah";
            TambahQ.MinimumWidth = 8;
            TambahQ.Name = "TambahQ";
            TambahQ.Text = "+";
            TambahQ.UseColumnTextForButtonValue = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantity";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            // 
            // Kurangiplis
            // 
            Kurangiplis.HeaderText = "Kurangi";
            Kurangiplis.MinimumWidth = 8;
            Kurangiplis.Name = "Kurangiplis";
            Kurangiplis.Text = "-";
            Kurangiplis.UseColumnTextForButtonValue = true;
            // 
            // AddToCart
            // 
            AddToCart.HeaderText = "Tambah Ke Keranjang";
            AddToCart.MinimumWidth = 8;
            AddToCart.Name = "AddToCart";
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
            LihatKeranjang.Location = new Point(458, 516);
            LihatKeranjang.Name = "LihatKeranjang";
            LihatKeranjang.Size = new Size(151, 34);
            LihatKeranjang.TabIndex = 2;
            LihatKeranjang.Text = "Lihat Keranjang";
            LihatKeranjang.UseVisualStyleBackColor = true;
            LihatKeranjang.Click += LihatKeranjang_Click;
            // 
            // btnPembayaran
            // 
            btnPembayaran.BackColor = Color.Transparent;
            btnPembayaran.FlatStyle = FlatStyle.Flat;
            btnPembayaran.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPembayaran.ForeColor = Color.FromArgb(0, 64, 64);
            btnPembayaran.Location = new Point(61, 189);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(242, 49);
            btnPembayaran.TabIndex = 3;
            btnPembayaran.Text = "Pembayaran";
            btnPembayaran.UseVisualStyleBackColor = false;
            // 
            // V_FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PRODUK_PELANGGAN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1117, 574);
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
        private DataGridViewTextBoxColumn NamaProduk2;
        private DataGridViewTextBoxColumn Deskripsi2;
        private DataGridViewTextBoxColumn Harga2;
        private DataGridViewTextBoxColumn Stok2;
        private DataGridViewButtonColumn TambahQ;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewButtonColumn Kurangiplis;
        private DataGridViewButtonColumn AddToCart;
        private Button btnPembayaran;
    }
}