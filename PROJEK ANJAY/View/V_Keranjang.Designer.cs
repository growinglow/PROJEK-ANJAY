namespace PROJEK_ANJAY.View
{
    partial class V_Keranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Keranjang));
            tblKeranjang = new DataGridView();
            produk = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnBuatPesanan = new Button();
            label1 = new Label();
            tbAlamat = new TextBox();
            btnLogout = new Button();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)tblKeranjang).BeginInit();
            SuspendLayout();
            // 
            // tblKeranjang
            // 
            tblKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblKeranjang.Columns.AddRange(new DataGridViewColumn[] { produk, harga, qty, Subtotal });
            tblKeranjang.Location = new Point(604, 203);
            tblKeranjang.Name = "tblKeranjang";
            tblKeranjang.RowHeadersWidth = 62;
            tblKeranjang.Size = new Size(814, 506);
            tblKeranjang.TabIndex = 0;
            // 
            // produk
            // 
            produk.HeaderText = "Nama Produk";
            produk.MinimumWidth = 8;
            produk.Name = "produk";
            produk.ReadOnly = true;
            produk.Width = 150;
            // 
            // harga
            // 
            harga.HeaderText = "Harga";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            harga.ReadOnly = true;
            harga.Width = 150;
            // 
            // qty
            // 
            qty.HeaderText = "Quantity";
            qty.MinimumWidth = 8;
            qty.Name = "qty";
            qty.ReadOnly = true;
            qty.Width = 150;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 8;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 150;
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuatPesanan.ForeColor = Color.FromArgb(0, 64, 0);
            btnBuatPesanan.Location = new Point(1201, 840);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(217, 53);
            btnBuatPesanan.TabIndex = 1;
            btnBuatPesanan.Text = "Buat Pesanan";
            btnBuatPesanan.UseVisualStyleBackColor = true;
            btnBuatPesanan.Click += btnBuatPesanan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(624, 744);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 2;
            label1.Text = "Detail alamat tujuan :";
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(841, 745);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(555, 31);
            tbAlamat.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 64, 0);
            btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(198, 819);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 59);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(0, 64, 0);
            btnKembali.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(198, 744);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(143, 55);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // V_Keranjang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(btnKembali);
            Controls.Add(btnLogout);
            Controls.Add(tbAlamat);
            Controls.Add(label1);
            Controls.Add(btnBuatPesanan);
            Controls.Add(tblKeranjang);
            DoubleBuffered = true;
            Name = "V_Keranjang";
            Text = "V_Keranjang";
            ((System.ComponentModel.ISupportInitialize)tblKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblKeranjang;
        private DataGridViewTextBoxColumn produk;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnBuatPesanan;
        private Label label1;
        private TextBox tbAlamat;
        private Button btnLogout;
        private Button btnKembali;
    }
}