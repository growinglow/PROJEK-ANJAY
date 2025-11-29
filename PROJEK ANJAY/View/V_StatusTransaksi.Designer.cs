namespace PROJEK_ANJAY.View
{
    partial class V_StatusTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_StatusTransaksi));
            btnProduk = new Button();
            btnStatusTr = new Button();
            btnRiwayatTr = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnProduk
            // 
            btnProduk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduk.ForeColor = Color.FromArgb(0, 64, 0);
            btnProduk.Location = new Point(79, 234);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(330, 59);
            btnProduk.TabIndex = 3;
            btnProduk.Text = "   Produk";
            btnProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnProduk.UseVisualStyleBackColor = true;
            // 
            // btnStatusTr
            // 
            btnStatusTr.BackColor = Color.FromArgb(0, 64, 0);
            btnStatusTr.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusTr.ForeColor = Color.White;
            btnStatusTr.Location = new Point(79, 321);
            btnStatusTr.Name = "btnStatusTr";
            btnStatusTr.Size = new Size(330, 62);
            btnStatusTr.TabIndex = 4;
            btnStatusTr.Text = "   Status Transaksi";
            btnStatusTr.TextAlign = ContentAlignment.MiddleLeft;
            btnStatusTr.UseVisualStyleBackColor = false;
            // 
            // btnRiwayatTr
            // 
            btnRiwayatTr.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTr.ForeColor = Color.FromArgb(0, 64, 0);
            btnRiwayatTr.Location = new Point(79, 414);
            btnRiwayatTr.Name = "btnRiwayatTr";
            btnRiwayatTr.Size = new Size(330, 61);
            btnRiwayatTr.TabIndex = 5;
            btnRiwayatTr.Text = "   Riwayat Transaksi";
            btnRiwayatTr.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTr.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 0);
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(196, 820);
            button4.Name = "button4";
            button4.Size = new Size(147, 59);
            button4.TabIndex = 6;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(601, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(820, 621);
            dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(79, 512);
            button1.Name = "button1";
            button1.Size = new Size(330, 60);
            button1.TabIndex = 8;
            button1.Text = "   Laporan Penjualan";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // V_StatusTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(btnRiwayatTr);
            Controls.Add(btnStatusTr);
            Controls.Add(btnProduk);
            DoubleBuffered = true;
            Name = "V_StatusTransaksi";
            Text = "V_StatusTransaksi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnProduk;
        private Button btnStatusTr;
        private Button btnRiwayatTr;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button1;
    }
}