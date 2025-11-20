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
            ((System.ComponentModel.ISupportInitialize)tblKeranjang).BeginInit();
            SuspendLayout();
            // 
            // tblKeranjang
            // 
            tblKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblKeranjang.Columns.AddRange(new DataGridViewColumn[] { NamaProduk3, Harga3, Qty3, Subtotal });
            tblKeranjang.Location = new Point(190, 161);
            tblKeranjang.Name = "tblKeranjang";
            tblKeranjang.RowHeadersWidth = 62;
            tblKeranjang.Size = new Size(578, 177);
            tblKeranjang.TabIndex = 0;
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
            btnKembali.Location = new Point(519, 378);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(656, 378);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(112, 34);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // V_Cart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheckout);
            Controls.Add(btnKembali);
            Controls.Add(lblTotal);
            Controls.Add(tblKeranjang);
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
    }
}