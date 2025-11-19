using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LONTAR
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tbuser = new TextBox();
            tbpw = new TextBox();
            btlogin = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();

            // 
            // tbuser
            // 
            tbuser.BackColor = SystemColors.ScrollBar;
            tbuser.BorderStyle = BorderStyle.None;
            tbuser.Location = new Point(256, 172);
            tbuser.Multiline = true;
            tbuser.Name = "tbuser";
            tbuser.Size = new Size(155, 30);
            tbuser.TabIndex = 0;

            // 
            // tbpw
            // 
            tbpw.BackColor = SystemColors.ScrollBar;
            tbpw.BorderStyle = BorderStyle.None;
            tbpw.Location = new Point(256, 232);
            tbpw.Multiline = true;
            tbpw.Name = "tbpw";
            tbpw.Size = new Size(155, 30);
            tbpw.TabIndex = 1;
            tbpw.UseSystemPasswordChar = true;

            // 
            // btlogin
            // 
            btlogin.BackColor = Color.Lime;
            btlogin.Location = new Point(295, 297);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(81, 33);
            btlogin.TabIndex = 2;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.Click += btlogin_Click;   // ← DIBENERIN

            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Location = new Point(415, 14);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrasi";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;

            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LOGIN;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(533, 348);
            Controls.Add(linkLabel1);
            Controls.Add(btlogin);
            Controls.Add(tbpw);
            Controls.Add(tbuser);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbuser;
        private TextBox tbpw;
        private Button btlogin;
        private LinkLabel linkLabel1;
    }
}
