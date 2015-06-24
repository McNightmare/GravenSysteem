namespace GravenAdministratie
{
    partial class AddGraveyard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGraveyard));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDateofDeath = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.groupBoxDeceased = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchDeceased = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxGrave = new System.Windows.Forms.GroupBox();
            this.groupBoxDeceased.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(553, 21);
            this.txtName.TabIndex = 0;
            // 
            // txtDateofDeath
            // 
            this.txtDateofDeath.Location = new System.Drawing.Point(720, 17);
            this.txtDateofDeath.Name = "txtDateofDeath";
            this.txtDateofDeath.ReadOnly = true;
            this.txtDateofDeath.Size = new System.Drawing.Size(272, 21);
            this.txtDateofDeath.TabIndex = 1;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(1052, 17);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(27, 21);
            this.txtGender.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(1134, 17);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(54, 21);
            this.txtAge.TabIndex = 3;
            // 
            // groupBoxDeceased
            // 
            this.groupBoxDeceased.Controls.Add(this.btnSearchDeceased);
            this.groupBoxDeceased.Controls.Add(this.label4);
            this.groupBoxDeceased.Controls.Add(this.label3);
            this.groupBoxDeceased.Controls.Add(this.label2);
            this.groupBoxDeceased.Controls.Add(this.label1);
            this.groupBoxDeceased.Controls.Add(this.txtAge);
            this.groupBoxDeceased.Controls.Add(this.txtName);
            this.groupBoxDeceased.Controls.Add(this.txtGender);
            this.groupBoxDeceased.Controls.Add(this.txtDateofDeath);
            this.groupBoxDeceased.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDeceased.Name = "groupBoxDeceased";
            this.groupBoxDeceased.Size = new System.Drawing.Size(1225, 44);
            this.groupBoxDeceased.TabIndex = 4;
            this.groupBoxDeceased.TabStop = false;
            this.groupBoxDeceased.Text = "Overledene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1085, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Leeftijd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(998, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geslacht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum Overlijden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // btnSearchDeceased
            // 
            this.btnSearchDeceased.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDeceased.Image")));
            this.btnSearchDeceased.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearchDeceased.Location = new System.Drawing.Point(1203, 15);
            this.btnSearchDeceased.Name = "btnSearchDeceased";
            this.btnSearchDeceased.Size = new System.Drawing.Size(16, 16);
            this.btnSearchDeceased.TabIndex = 5;
            // 
            // groupBoxGrave
            // 
            this.groupBoxGrave.Location = new System.Drawing.Point(12, 62);
            this.groupBoxGrave.Name = "groupBoxGrave";
            this.groupBoxGrave.Size = new System.Drawing.Size(1225, 293);
            this.groupBoxGrave.TabIndex = 5;
            this.groupBoxGrave.TabStop = false;
            this.groupBoxGrave.Text = "Graf";
            // 
            // AddGraveyard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 542);
            this.Controls.Add(this.groupBoxGrave);
            this.Controls.Add(this.groupBoxDeceased);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGraveyard";
            this.Text = "AddGraveyard";
            this.groupBoxDeceased.ResumeLayout(false);
            this.groupBoxDeceased.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDateofDeath;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.GroupBox groupBoxDeceased;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSearchDeceased;
        private System.Windows.Forms.GroupBox groupBoxGrave;
    }
}