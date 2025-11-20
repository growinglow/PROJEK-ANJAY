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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 30);
            label1.Name = "label1";
            label1.Size = new Size(206, 27);
            label1.TabIndex = 0;
            label1.Text = "Tambah Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 105);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 213);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Deskripsi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 105);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 213);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 4;
            label5.Text = "Stok";
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Location = new Point(248, 146);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(150, 31);
            tbNamaProduk.TabIndex = 5;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(254, 259);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(150, 31);
            tbDeskripsi.TabIndex = 6;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(605, 142);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(150, 31);
            tbHarga.TabIndex = 7;
            // 
            // tbStok
            // 
            tbStok.Location = new Point(605, 256);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(150, 31);
            tbStok.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(452, 337);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // V_CreateEditProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}