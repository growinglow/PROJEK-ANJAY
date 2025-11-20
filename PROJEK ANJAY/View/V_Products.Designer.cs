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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnTambahProduk = new Button();
            Id = new DataGridViewTextBoxColumn();
            NamaProduk = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 49);
            label1.Name = "label1";
            label1.Size = new Size(225, 27);
            label1.TabIndex = 0;
            label1.Text = "PRODUK SiLontar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NamaProduk, Deskripsi, Harga, Stok, Edit, Delete });
            dataGridView1.Location = new Point(147, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(721, 287);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.BackColor = Color.Lime;
            btnTambahProduk.Location = new Point(714, 96);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(154, 39);
            btnTambahProduk.TabIndex = 2;
            btnTambahProduk.Text = "Tambah Produk";
            btnTambahProduk.UseVisualStyleBackColor = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id Produk";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
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
            // V_Products
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 514);
            Controls.Add(btnTambahProduk);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "V_Products";
            Text = "V_Products";
            Load += V_Products_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnTambahProduk;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NamaProduk;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}