namespace PROJEK_ANJAY
{
    partial class V_Products
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
            dataGridView1 = new DataGridView();
            NamaProduk = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnTambahProduk = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnLapPenjualan = new Button();
            btnStatusTr = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaProduk, Deskripsi, Harga, Stok, Edit, Delete });
            dataGridView1.Location = new Point(590, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(816, 673);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // NamaProduk
            // 
            NamaProduk.DataPropertyName = "NamaProduk";
            NamaProduk.HeaderText = "Nama Produk";
            NamaProduk.MinimumWidth = 8;
            NamaProduk.Name = "NamaProduk";
            // 
            // Deskripsi
            // 
            Deskripsi.DataPropertyName = "Deskripsi";
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 8;
            Deskripsi.Name = "Deskripsi";
            // 
            // Harga
            // 
            Harga.DataPropertyName = "Harga";
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 8;
            Harga.Name = "Harga";
            // 
            // Stok
            // 
            Stok.DataPropertyName = "Stok";
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 8;
            Stok.Name = "Stok";
            // 
            // Edit
            // 
            Edit.DataPropertyName = "Id";
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Id";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.BackColor = Color.White;
            btnTambahProduk.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahProduk.ForeColor = Color.FromArgb(0, 64, 0);
            btnTambahProduk.Location = new Point(1166, 826);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(240, 50);
            btnTambahProduk.TabIndex = 2;
            btnTambahProduk.Text = "Tambah Produk";
            btnTambahProduk.UseVisualStyleBackColor = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(195, 819);
            button1.Name = "button1";
            button1.Size = new Size(147, 59);
            button1.TabIndex = 3;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Location = new Point(78, 412);
            button2.Name = "button2";
            button2.Size = new Size(327, 61);
            button2.TabIndex = 4;
            button2.Text = "Riwayat Transaksi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 0);
            button3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(78, 233);
            button3.Name = "button3";
            button3.Size = new Size(327, 57);
            button3.TabIndex = 5;
            button3.Text = "   Produk";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnLapPenjualan
            // 
            btnLapPenjualan.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLapPenjualan.ForeColor = Color.FromArgb(0, 64, 0);
            btnLapPenjualan.Location = new Point(78, 496);
            btnLapPenjualan.Name = "btnLapPenjualan";
            btnLapPenjualan.Size = new Size(327, 60);
            btnLapPenjualan.TabIndex = 6;
            btnLapPenjualan.Text = "  Laporan Penjualan";
            btnLapPenjualan.UseVisualStyleBackColor = true;
            btnLapPenjualan.Click += btnLapPenjualan_Click;
            // 
            // btnStatusTr
            // 
            btnStatusTr.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusTr.ForeColor = Color.FromArgb(0, 64, 0);
            btnStatusTr.Location = new Point(78, 322);
            btnStatusTr.Name = "btnStatusTr";
            btnStatusTr.Size = new Size(327, 59);
            btnStatusTr.TabIndex = 7;
            btnStatusTr.Text = "   Status Transaksi";
            btnStatusTr.TextAlign = ContentAlignment.MiddleLeft;
            btnStatusTr.UseVisualStyleBackColor = true;
            // 
            // V_Products
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PRODUK_ADMIN__1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(btnStatusTr);
            Controls.Add(btnLapPenjualan);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTambahProduk);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "V_Products";
            Text = "V_Products";
            Load += V_Products_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnTambahProduk;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NamaProduk;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnLapPenjualan;
        private Button btnStatusTr;
    }
}