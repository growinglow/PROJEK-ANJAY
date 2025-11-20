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
            Id2 = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)tblDashbord).BeginInit();
            SuspendLayout();
            // 
            // tblDashbord
            // 
            tblDashbord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblDashbord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDashbord.Columns.AddRange(new DataGridViewColumn[] { Id2, NamaProduk2, Deskripsi2, Harga2, Stok2, TambahQ, Qty, Kurangiplis, AddToCart });
            tblDashbord.Location = new Point(200, 142);
            tblDashbord.Name = "tblDashbord";
            tblDashbord.RowHeadersWidth = 62;
            tblDashbord.Size = new Size(788, 337);
            tblDashbord.TabIndex = 0;
            tblDashbord.CellContentClick += tblDashbord_CellContentClick;
            // 
            // Id2
            // 
            Id2.DataPropertyName = "Id";
            Id2.HeaderText = "Id Produk";
            Id2.MinimumWidth = 8;
            Id2.Name = "Id2";
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
            LihatKeranjang.Location = new Point(200, 504);
            LihatKeranjang.Name = "LihatKeranjang";
            LihatKeranjang.Size = new Size(151, 34);
            LihatKeranjang.TabIndex = 2;
            LihatKeranjang.Text = "Lihat Keranjang";
            LihatKeranjang.UseVisualStyleBackColor = true;
            LihatKeranjang.Click += LihatKeranjang_Click;
            // 
            // V_FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 574);
            Controls.Add(LihatKeranjang);
            Controls.Add(lblWelcome);
            Controls.Add(tblDashbord);
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
        private DataGridViewTextBoxColumn Id2;
        private DataGridViewTextBoxColumn NamaProduk2;
        private DataGridViewTextBoxColumn Deskripsi2;
        private DataGridViewTextBoxColumn Harga2;
        private DataGridViewTextBoxColumn Stok2;
        private DataGridViewButtonColumn TambahQ;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewButtonColumn Kurangiplis;
        private DataGridViewButtonColumn AddToCart;
    }
}