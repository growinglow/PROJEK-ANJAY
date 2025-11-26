namespace PROJEK_ANJAY
{
    partial class V_CreateEditProduk
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNamaProduk = new TextBox();
            tbDeskripsi = new TextBox();
            tbHarga = new TextBox();
            tbStok = new TextBox();
            btnSimpan = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(800, 169);
            label1.Name = "label1";
            label1.Size = new Size(411, 54);
            label1.TabIndex = 0;
            label1.Text = "Tambah/Edit Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(695, 271);
            label2.Name = "label2";
            label2.Size = new Size(192, 38);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(695, 438);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 2;
            label3.Text = "Deskripsi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1104, 271);
            label4.Name = "label4";
            label4.Size = new Size(95, 38);
            label4.TabIndex = 3;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1104, 438);
            label5.Name = "label5";
            label5.Size = new Size(73, 38);
            label5.TabIndex = 4;
            label5.Text = "Stok";
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaProduk.Location = new Point(695, 326);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(381, 45);
            tbNamaProduk.TabIndex = 5;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDeskripsi.Location = new Point(695, 494);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(381, 45);
            tbDeskripsi.TabIndex = 6;
            // 
            // tbHarga
            // 
            tbHarga.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(1104, 326);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(192, 45);
            tbHarga.TabIndex = 7;
            // 
            // tbStok
            // 
            tbStok.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStok.Location = new Point(1104, 494);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(201, 45);
            tbStok.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(0, 64, 0);
            btnSimpan.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(922, 627);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(154, 54);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(79, 322);
            button1.Name = "button1";
            button1.Size = new Size(326, 64);
            button1.TabIndex = 10;
            button1.Text = "   Status Transaksi";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Location = new Point(79, 413);
            button2.Name = "button2";
            button2.Size = new Size(326, 63);
            button2.TabIndex = 11;
            button2.Text = "Riwayat Transaksi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(0, 64, 0);
            button3.Location = new Point(79, 494);
            button3.Name = "button3";
            button3.Size = new Size(326, 62);
            button3.TabIndex = 12;
            button3.Text = "   Laporan Penjualan";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 0);
            button4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(196, 818);
            button4.Name = "button4";
            button4.Size = new Size(143, 61);
            button4.TabIndex = 13;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // V_CreateEditProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PRODUK_ADMIN__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSimpan);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(tbDeskripsi);
            Controls.Add(tbNamaProduk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "V_CreateEditProduk";
            Text = "V_CreateEditProduk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNamaProduk;
        private TextBox tbDeskripsi;
        private TextBox tbHarga;
        private TextBox tbStok;
        private Button btnSimpan;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}