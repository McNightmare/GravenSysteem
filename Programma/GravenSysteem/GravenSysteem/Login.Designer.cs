namespace GravenSysteem
{
    partial class frmLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pnlSplashscreen = new System.Windows.Forms.Panel();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.pnlSplashscreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(248)))));
            this.pnlLogin.Controls.Add(this.btnClose);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Location = new System.Drawing.Point(13, 21);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(284, 35);
            this.pnlLogin.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::GravenSysteem.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(249, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Roboto", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(69, 4);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(162, 26);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Graven Systeem";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(78, 100);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(248)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(51, 145);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(209, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOG   IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbUsername
            // 
            this.pbUsername.BackgroundImage = global::GravenSysteem.Properties.Resources.PasswordIcon1;
            this.pbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsername.Location = new System.Drawing.Point(51, 69);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(25, 25);
            this.pbUsername.TabIndex = 8;
            this.pbUsername.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 15F);
            this.txtUsername.Location = new System.Drawing.Point(78, 69);
            this.txtUsername.MaxLength = 15;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // pbPassword
            // 
            this.pbPassword.BackgroundImage = global::GravenSysteem.Properties.Resources.PasswordIcon;
            this.pbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPassword.Location = new System.Drawing.Point(51, 100);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(25, 25);
            this.pbPassword.TabIndex = 9;
            this.pbPassword.TabStop = false;
            // 
            // pnlSplashscreen
            // 
            this.pnlSplashscreen.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSplashscreen.Controls.Add(this.btnLogin);
            this.pnlSplashscreen.Controls.Add(this.pbPassword);
            this.pnlSplashscreen.Controls.Add(this.pnlLogin);
            this.pnlSplashscreen.Controls.Add(this.txtUsername);
            this.pnlSplashscreen.Controls.Add(this.txtPassword);
            this.pnlSplashscreen.Controls.Add(this.pbUsername);
            this.pnlSplashscreen.Location = new System.Drawing.Point(68, 145);
            this.pnlSplashscreen.Name = "pnlSplashscreen";
            this.pnlSplashscreen.Size = new System.Drawing.Size(308, 198);
            this.pnlSplashscreen.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(440, 498);
            this.Controls.Add(this.pnlSplashscreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.pnlSplashscreen.ResumeLayout(false);
            this.pnlSplashscreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Panel pnlSplashscreen;
    }
}