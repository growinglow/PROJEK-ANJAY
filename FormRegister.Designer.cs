using System;
using System.Drawing;
using System.Windows.Forms;

namespace LONTAR
{
    partial class FormRegister
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
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpw = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbnotelp = new System.Windows.Forms.TextBox();
            this.btregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(255, 136);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(191, 23);
            this.tbuser.TabIndex = 0;
            // 
            // tbpw
            // 
            this.tbpw.Location = new System.Drawing.Point(255, 196);
            this.tbpw.Name = "tbpw";
            this.tbpw.Size = new System.Drawing.Size(191, 23);
            this.tbpw.TabIndex = 1;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(255, 258);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(191, 23);
            this.tbemail.TabIndex = 2;
            // 
            // tbnotelp
            // 
            this.tbnotelp.Location = new System.Drawing.Point(255, 321);
            this.tbnotelp.Name = "tbnotelp";
            this.tbnotelp.Size = new System.Drawing.Size(191, 23);
            this.tbnotelp.TabIndex = 3;
            // 
            // btregister
            // 
            this.btregister.Location = new System.Drawing.Point(317, 354);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(73, 31);
            this.btregister.TabIndex = 4;
            this.btregister.Text = "Register";
            this.btregister.UseVisualStyleBackColor = true;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LONTAR.Properties.Resources.REGISTER;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.tbnotelp);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbpw);
            this.Controls.Add(this.tbuser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "Form Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox tbuser;
        private TextBox tbpw;
        private TextBox tbemail;
        private TextBox tbnotelp;
        private Button btregister;
    }
}
