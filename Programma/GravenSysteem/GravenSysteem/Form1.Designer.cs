namespace GravenSysteem
{
    partial class frmMain
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
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFrame.SuspendLayout();
            this.pnlMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(248)))));
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Controls.Add(this.btnClose);
            this.pnlFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(992, 46);
            this.pnlFrame.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(388, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Graven Systeem";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(946, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(184)))), ((int)(((byte)(250)))));
            this.pnlMenuBar.Controls.Add(this.pnlSeperator);
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 46);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(992, 30);
            this.pnlMenuBar.TabIndex = 1;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.Black;
            this.pnlSeperator.Location = new System.Drawing.Point(0, 0);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(994, 1);
            this.pnlSeperator.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 63);
            this.panel1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenuBar);
            this.Controls.Add(this.pnlFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlFrame.ResumeLayout(false);
            this.pnlFrame.PerformLayout();
            this.pnlMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Panel panel1;
    }
}

