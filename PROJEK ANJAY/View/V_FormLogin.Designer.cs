namespace PROJEK_ANJAY
{
    partial class V_FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(861, 816);
            button1.Name = "button1";
            button1.Size = new Size(162, 62);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.FromArgb(64, 64, 64);
            tbUsername.Location = new Point(738, 445);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(390, 63);
            tbUsername.TabIndex = 2;
            tbUsername.TextAlign = HorizontalAlignment.Center;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbPassword.Location = new Point(749, 604);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(369, 66);
            tbPassword.TabIndex = 4;
            tbPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1168, 18);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 5;
            label1.Text = "Belum memiliki akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.FromArgb(0, 64, 0);
            linkLabel1.Location = new Point(1387, 20);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // V_FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = Properties.Resources.LOGIN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "V_FormLogin";
            Text = "V_FormLogin";
            Load += V_FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
