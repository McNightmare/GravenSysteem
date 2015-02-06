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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Toevoegen = new System.Windows.Forms.TabPage();
            this.Bewerken = new System.Windows.Forms.TabPage();
            this.Verwijderen = new System.Windows.Forms.TabPage();
            this.Zoeken = new System.Windows.Forms.TabPage();
            this.Rapporten = new System.Windows.Forms.TabPage();
            this.Beveiliging = new System.Windows.Forms.TabPage();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddGraf = new System.Windows.Forms.Button();
            this.btnAddArtikel = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.btnAddOverledenen = new System.Windows.Forms.Button();
            this.pnlFrame.SuspendLayout();
            this.pnlMenuBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Toevoegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(248)))));
            this.pnlFrame.Controls.Add(this.btnMinimize);
            this.pnlFrame.Controls.Add(this.btnResize);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Controls.Add(this.btnClose);
            this.pnlFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(992, 46);
            this.pnlFrame.TabIndex = 0;
            this.pnlFrame.DoubleClick += new System.EventHandler(this.pnlFrame_DoubleClick);
            this.pnlFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFrame_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::GravenSysteem.Properties.Resources.Minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(849, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 46);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.BackgroundImage = global::GravenSysteem.Properties.Resources.Resize;
            this.btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.Location = new System.Drawing.Point(898, -2);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(46, 46);
            this.btnResize.TabIndex = 2;
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(388, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Graven Systeem";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::GravenSysteem.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(946, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(184)))), ((int)(((byte)(250)))));
            this.pnlMenuBar.Controls.Add(this.tabControl1);
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 47);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(992, 93);
            this.pnlMenuBar.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Toevoegen);
            this.tabControl1.Controls.Add(this.Bewerken);
            this.tabControl1.Controls.Add(this.Verwijderen);
            this.tabControl1.Controls.Add(this.Zoeken);
            this.tabControl1.Controls.Add(this.Rapporten);
            this.tabControl1.Controls.Add(this.Beveiliging);
            this.tabControl1.Location = new System.Drawing.Point(-7, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // Toevoegen
            // 
            this.Toevoegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Toevoegen.Controls.Add(this.btnAddOverledenen);
            this.Toevoegen.Controls.Add(this.btnAddDocument);
            this.Toevoegen.Controls.Add(this.btnAddSubject);
            this.Toevoegen.Controls.Add(this.btnAddArtikel);
            this.Toevoegen.Controls.Add(this.btnAddGraf);
            this.Toevoegen.Location = new System.Drawing.Point(4, 25);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Padding = new System.Windows.Forms.Padding(3);
            this.Toevoegen.Size = new System.Drawing.Size(1005, 71);
            this.Toevoegen.TabIndex = 0;
            this.Toevoegen.Text = "Toevoegen";
            // 
            // Bewerken
            // 
            this.Bewerken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Bewerken.Location = new System.Drawing.Point(4, 25);
            this.Bewerken.Name = "Bewerken";
            this.Bewerken.Padding = new System.Windows.Forms.Padding(3);
            this.Bewerken.Size = new System.Drawing.Size(1005, 71);
            this.Bewerken.TabIndex = 1;
            this.Bewerken.Text = "Bewerken";
            // 
            // Verwijderen
            // 
            this.Verwijderen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Verwijderen.Location = new System.Drawing.Point(4, 25);
            this.Verwijderen.Name = "Verwijderen";
            this.Verwijderen.Padding = new System.Windows.Forms.Padding(3);
            this.Verwijderen.Size = new System.Drawing.Size(1005, 71);
            this.Verwijderen.TabIndex = 2;
            this.Verwijderen.Text = "Verwijderen";
            // 
            // Zoeken
            // 
            this.Zoeken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Zoeken.Location = new System.Drawing.Point(4, 25);
            this.Zoeken.Name = "Zoeken";
            this.Zoeken.Padding = new System.Windows.Forms.Padding(3);
            this.Zoeken.Size = new System.Drawing.Size(1005, 71);
            this.Zoeken.TabIndex = 3;
            this.Zoeken.Text = "Zoeken";
            // 
            // Rapporten
            // 
            this.Rapporten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Rapporten.Location = new System.Drawing.Point(4, 25);
            this.Rapporten.Name = "Rapporten";
            this.Rapporten.Padding = new System.Windows.Forms.Padding(3);
            this.Rapporten.Size = new System.Drawing.Size(1005, 71);
            this.Rapporten.TabIndex = 4;
            this.Rapporten.Text = "Rapporten";
            // 
            // Beveiliging
            // 
            this.Beveiliging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Beveiliging.Location = new System.Drawing.Point(4, 25);
            this.Beveiliging.Name = "Beveiliging";
            this.Beveiliging.Padding = new System.Windows.Forms.Padding(3);
            this.Beveiliging.Size = new System.Drawing.Size(1005, 71);
            this.Beveiliging.TabIndex = 5;
            this.Beveiliging.Text = "Beveiliging";
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.DimGray;
            this.pnlSeperator.Location = new System.Drawing.Point(0, 139);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(994, 1);
            this.pnlSeperator.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 1);
            this.panel2.TabIndex = 1;
            // 
            // btnAddGraf
            // 
            this.btnAddGraf.FlatAppearance.BorderSize = 0;
            this.btnAddGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGraf.Location = new System.Drawing.Point(196, 11);
            this.btnAddGraf.Name = "btnAddGraf";
            this.btnAddGraf.Size = new System.Drawing.Size(89, 45);
            this.btnAddGraf.TabIndex = 2;
            this.btnAddGraf.Text = "Graf";
            this.btnAddGraf.UseVisualStyleBackColor = true;
            // 
            // btnAddArtikel
            // 
            this.btnAddArtikel.FlatAppearance.BorderSize = 0;
            this.btnAddArtikel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtikel.Location = new System.Drawing.Point(281, 11);
            this.btnAddArtikel.Name = "btnAddArtikel";
            this.btnAddArtikel.Size = new System.Drawing.Size(89, 45);
            this.btnAddArtikel.TabIndex = 3;
            this.btnAddArtikel.Text = "Artikel";
            this.btnAddArtikel.UseVisualStyleBackColor = true;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.FlatAppearance.BorderSize = 0;
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Location = new System.Drawing.Point(6, 11);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(89, 45);
            this.btnAddSubject.TabIndex = 2;
            this.btnAddSubject.Text = "Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.FlatAppearance.BorderSize = 0;
            this.btnAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDocument.Location = new System.Drawing.Point(376, 11);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(89, 45);
            this.btnAddDocument.TabIndex = 4;
            this.btnAddDocument.Text = "Document";
            this.btnAddDocument.UseVisualStyleBackColor = true;
            // 
            // btnAddOverledenen
            // 
            this.btnAddOverledenen.FlatAppearance.BorderSize = 0;
            this.btnAddOverledenen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOverledenen.Location = new System.Drawing.Point(101, 11);
            this.btnAddOverledenen.Name = "btnAddOverledenen";
            this.btnAddOverledenen.Size = new System.Drawing.Size(89, 45);
            this.btnAddOverledenen.TabIndex = 2;
            this.btnAddOverledenen.Text = "Overledenen";
            this.btnAddOverledenen.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSeperator);
            this.Controls.Add(this.pnlMenuBar);
            this.Controls.Add(this.pnlFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlFrame.ResumeLayout(false);
            this.pnlFrame.PerformLayout();
            this.pnlMenuBar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Toevoegen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Bewerken;
        private System.Windows.Forms.TabPage Toevoegen;
        private System.Windows.Forms.TabPage Verwijderen;
        private System.Windows.Forms.TabPage Zoeken;
        private System.Windows.Forms.TabPage Rapporten;
        private System.Windows.Forms.TabPage Beveiliging;
        private System.Windows.Forms.Button btnAddGraf;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnAddArtikel;
        private System.Windows.Forms.Button btnAddOverledenen;
    }
}

