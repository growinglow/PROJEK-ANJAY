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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(406, 413);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(351, 230);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(201, 31);
            tbUsername.TabIndex = 2;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(360, 308);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(192, 31);
            tbPassword.TabIndex = 4;
            // 
            // V_FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = Properties.Resources.LOGIN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(722, 480);
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
    }
}
