namespace PROJEK_ANJAY.View
{
    partial class V_Cart
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
            tblKeranjang = new DataGridView();
            NamaProduk3 = new DataGridViewTextBoxColumn();
            Harga3 = new DataGridViewTextBoxColumn();
            Qty3 = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnKembali = new Button();
            btnCheckout = new Button();
            btnBayarNanti = new Button();
            btnPembayaran = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)tblKeranjang).BeginInit();
            SuspendLayout();
            // 
            // tblKeranjang
            // 
            tblKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblKeranjang.Columns.AddRange(new DataGridViewColumn[] { NamaProduk3, Harga3, Qty3, Subtotal });
            tblKeranjang.Location = new Point(604, 204);
            tblKeranjang.Name = "tblKeranjang";
            tblKeranjang.RowHeadersWidth = 62;
            tblKeranjang.Size = new Size(816, 584);
            tblKeranjang.TabIndex = 0;
            tblKeranjang.CellContentClick += tblKeranjang_CellContentClick;
            // 
            // NamaProduk3
            // 
            NamaProduk3.HeaderText = "Nama Produk";
            NamaProduk3.MinimumWidth = 8;
            NamaProduk3.Name = "NamaProduk3";
            // 
            // Harga3
            // 
            Harga3.HeaderText = "Harga";
            Harga3.MinimumWidth = 8;
            Harga3.Name = "Harga3";
            // 
            // Qty3
            // 
            Qty3.HeaderText = "Quantity";
            Qty3.MinimumWidth = 8;
            Qty3.Name = "Qty3";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Sub Total";
            Subtotal.MinimumWidth = 8;
            Subtotal.Name = "Subtotal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(160, 416);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 1;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(0, 64, 0);
            btnKembali.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(188, 740);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(160, 65);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.FromArgb(0, 64, 0);
            btnCheckout.Location = new Point(995, 829);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(425, 54);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Pesan dan Bayar Sekarang";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnBayarNanti
            // 
            btnBayarNanti.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayarNanti.ForeColor = Color.FromArgb(0, 64, 0);
            btnBayarNanti.Location = new Point(604, 829);
            btnBayarNanti.Name = "btnBayarNanti";
            btnBayarNanti.Size = new Size(370, 54);
            btnBayarNanti.TabIndex = 4;
            btnBayarNanti.Text = "Pesan dan Bayar Nanti";
            btnBayarNanti.UseVisualStyleBackColor = true;
            btnBayarNanti.Click += btnBayarNanti_Click;
            // 
            // btnPembayaran
            // 
            btnPembayaran.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPembayaran.ForeColor = Color.FromArgb(0, 64, 0);
            btnPembayaran.ImageAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.Location = new Point(75, 320);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(329, 63);
            btnPembayaran.TabIndex = 5;
            btnPembayaran.Text = "   Pembayaran";
            btnPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.UseVisualStyleBackColor = true;
            btnPembayaran.Click += btnPembayaran_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(188, 819);
            button1.Name = "button1";
            button1.Size = new Size(160, 64);
            button1.TabIndex = 6;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Location = new Point(75, 411);
            button2.Name = "button2";
            button2.Size = new Size(329, 61);
            button2.TabIndex = 7;
            button2.Text = "Riwayat Transaksi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 0);
            button3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(75, 231);
            button3.Name = "button3";
            button3.Size = new Size(329, 60);
            button3.TabIndex = 8;
            button3.Text = "   Produk";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // V_Cart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PRODUK_PELANGGAN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPembayaran);
            Controls.Add(btnBayarNanti);
            Controls.Add(btnCheckout);
            Controls.Add(btnKembali);
            Controls.Add(lblTotal);
            Controls.Add(tblKeranjang);
            DoubleBuffered = true;
            Name = "V_Cart";
            Text = "V_Cart";
            ((System.ComponentModel.ISupportInitialize)tblKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblKeranjang;
        private DataGridViewTextBoxColumn NamaProduk3;
        private DataGridViewTextBoxColumn Harga3;
        private DataGridViewTextBoxColumn Qty3;
        private DataGridViewTextBoxColumn Subtotal;
        private Label lblTotal;
        private Button btnKembali;
        private Button btnCheckout;
        private Button btnBayarNanti;
        private Button btnPembayaran;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}