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
            label1 = new Label();
            label2 = new Label();
            btnSignUp = new Button();
            label3 = new Label();
            loginLink = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            tb = new Label();
            tbNotelp = new TextBox();
            tbEmail = new TextBox();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(263, 121);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(150, 31);
            tbUsername.TabIndex = 1;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(263, 183);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(150, 31);
            tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 93);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 155);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(352, 352);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(112, 34);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 389);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 6;
            label3.Text = "Sudah memiliki akun?";
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.LinkColor = Color.Green;
            loginLink.Location = new Point(453, 389);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(66, 25);
            loginLink.TabIndex = 8;
            loginLink.TabStop = true;
            loginLink.Text = "Sign in";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 40);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 9;
            label4.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 217);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // tb
            // 
            tb.AutoSize = true;
            tb.Location = new Point(263, 279);
            tb.Name = "tb";
            tb.Size = new Size(102, 25);
            tb.TabIndex = 11;
            tb.Text = "No Telepon";
            // 
            // tbNotelp
            // 
            tbNotelp.Location = new Point(263, 307);
            tbNotelp.Name = "tbNotelp";
            tbNotelp.Size = new Size(150, 31);
            tbNotelp.TabIndex = 12;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(263, 245);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(150, 31);
            tbEmail.TabIndex = 13;
            // 
            // V_FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbEmail);
            Controls.Add(tbNotelp);
            Controls.Add(tb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(loginLink);
            Controls.Add(label3);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Name = "V_FormRegister";
            Text = "V_FormRegister";
            Load += V_FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnSignUp;
        private Label label3;
        private LinkLabel loginLink;
        private Label label4;
        private Label label5;
        private Label tb;
        private TextBox tbNotelp;
        private TextBox tbEmail;
    }
}