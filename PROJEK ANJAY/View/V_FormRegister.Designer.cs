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
            tbUsername.Location = new Point(263, 141);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(215, 34);
            tbUsername.TabIndex = 1;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(263, 203);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(215, 34);
            tbPassword.TabIndex = 2;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(0, 192, 0);
            btnSignUp.Location = new Point(321, 385);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(112, 34);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "REGISTER";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.BackColor = Color.Yellow;
            loginLink.LinkColor = Color.Green;
            loginLink.Location = new Point(649, 30);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(63, 25);
            loginLink.TabIndex = 8;
            loginLink.TabStop = true;
            loginLink.Text = "LOGIN";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // tbNotelp
            // 
            tbNotelp.Location = new Point(263, 333);
            tbNotelp.Multiline = true;
            tbNotelp.Name = "tbNotelp";
            tbNotelp.Size = new Size(215, 30);
            tbNotelp.TabIndex = 12;
            tbNotelp.TextChanged += tbNotelp_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(263, 266);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(215, 33);
            tbEmail.TabIndex = 13;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // V_FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = Properties.Resources.REGISTER;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 474);
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