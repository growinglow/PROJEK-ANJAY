namespace PROJEK_ANJAY
{
    partial class V_FormRegister
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnSignUp = new Button();
            loginLink = new LinkLabel();
            tbNotelp = new TextBox();
            tbEmail = new TextBox();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Cursor = Cursors.IBeam;
            tbUsername.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.FromArgb(64, 64, 64);
            tbUsername.Location = new Point(546, 272);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(434, 60);
            tbUsername.TabIndex = 1;
            tbUsername.TextAlign = HorizontalAlignment.Center;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbPassword.Location = new Point(546, 397);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(434, 60);
            tbPassword.TabIndex = 2;
            tbPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(0, 192, 0);
            btnSignUp.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(670, 751);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(208, 76);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "REGISTER";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.BackColor = Color.Yellow;
            loginLink.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLink.LinkColor = Color.Green;
            loginLink.Location = new Point(1351, 24);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(106, 38);
            loginLink.TabIndex = 8;
            loginLink.TabStop = true;
            loginLink.Text = "LOGIN";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // tbNotelp
            // 
            tbNotelp.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNotelp.Location = new Point(546, 657);
            tbNotelp.Multiline = true;
            tbNotelp.Name = "tbNotelp";
            tbNotelp.Size = new Size(434, 58);
            tbNotelp.TabIndex = 12;
            tbNotelp.TextAlign = HorizontalAlignment.Center;
            tbNotelp.TextChanged += tbNotelp_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.FromArgb(64, 64, 64);
            tbEmail.Location = new Point(546, 524);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(434, 62);
            tbEmail.TabIndex = 13;
            tbEmail.TextAlign = HorizontalAlignment.Center;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // V_FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = Properties.Resources.REGISTER;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1490, 926);
            Controls.Add(tbEmail);
            Controls.Add(tbNotelp);
            Controls.Add(loginLink);
            Controls.Add(btnSignUp);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            DoubleBuffered = true;
            Name = "V_FormRegister";
            Text = "V_FormRegister";
            Load += V_FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnSignUp;
        private LinkLabel loginLink;
        private TextBox tbNotelp;
        private TextBox tbEmail;
    }
}