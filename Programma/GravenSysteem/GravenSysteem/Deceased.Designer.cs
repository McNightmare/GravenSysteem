namespace GravenSysteem
{
    partial class Deceased
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
            this.groupBoxDeceased = new System.Windows.Forms.GroupBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.cbBoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxGrave = new System.Windows.Forms.GroupBox();
            this.lblBurial = new System.Windows.Forms.Label();
            this.cbBoxBurial = new System.Windows.Forms.ComboBox();
            this.lblGraveType = new System.Windows.Forms.Label();
            this.txtBoxGraveType = new System.Windows.Forms.TextBox();
            this.groupBoxDeceased.SuspendLayout();
            this.groupBoxGrave.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDeceased
            // 
            this.groupBoxDeceased.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeceased.Controls.Add(this.txtBoxAge);
            this.groupBoxDeceased.Controls.Add(this.cbBoxGender);
            this.groupBoxDeceased.Controls.Add(this.dateTimePicker1);
            this.groupBoxDeceased.Controls.Add(this.lblGender);
            this.groupBoxDeceased.Controls.Add(this.lblAge);
            this.groupBoxDeceased.Controls.Add(this.lblDate);
            this.groupBoxDeceased.Controls.Add(this.txtBoxName);
            this.groupBoxDeceased.Controls.Add(this.lblName);
            this.groupBoxDeceased.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDeceased.Name = "groupBoxDeceased";
            this.groupBoxDeceased.Size = new System.Drawing.Size(968, 48);
            this.groupBoxDeceased.TabIndex = 0;
            this.groupBoxDeceased.TabStop = false;
            this.groupBoxDeceased.Text = "Overledene";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAge.Location = new System.Drawing.Point(885, 18);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(32, 20);
            this.txtBoxAge.TabIndex = 4;
            // 
            // cbBoxGender
            // 
            this.cbBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxGender.FormattingEnabled = true;
            this.cbBoxGender.Items.AddRange(new object[] {
            "M",
            "V"});
            this.cbBoxGender.Location = new System.Drawing.Point(773, 18);
            this.cbBoxGender.Name = "cbBoxGender";
            this.cbBoxGender.Size = new System.Drawing.Size(56, 21);
            this.cbBoxGender.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(625, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(718, 21);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Geslacht";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(837, 21);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Leeftijd";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(531, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Datum Overlijden";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxName.Location = new System.Drawing.Point(47, 18);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(478, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naam";
            // 
            // groupBoxGrave
            // 
            this.groupBoxGrave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGrave.Controls.Add(this.txtBoxGraveType);
            this.groupBoxGrave.Controls.Add(this.lblGraveType);
            this.groupBoxGrave.Controls.Add(this.cbBoxBurial);
            this.groupBoxGrave.Controls.Add(this.lblBurial);
            this.groupBoxGrave.Location = new System.Drawing.Point(12, 66);
            this.groupBoxGrave.Name = "groupBoxGrave";
            this.groupBoxGrave.Size = new System.Drawing.Size(968, 186);
            this.groupBoxGrave.TabIndex = 1;
            this.groupBoxGrave.TabStop = false;
            this.groupBoxGrave.Text = "Graf";
            // 
            // lblBurial
            // 
            this.lblBurial.AutoSize = true;
            this.lblBurial.Location = new System.Drawing.Point(6, 28);
            this.lblBurial.Name = "lblBurial";
            this.lblBurial.Size = new System.Drawing.Size(72, 13);
            this.lblBurial.TabIndex = 2;
            this.lblBurial.Text = "Begraafplaats";
            // 
            // cbBoxBurial
            // 
            this.cbBoxBurial.FormattingEnabled = true;
            this.cbBoxBurial.Items.AddRange(new object[] {
            "Algemene begraafplaats"});
            this.cbBoxBurial.Location = new System.Drawing.Point(84, 25);
            this.cbBoxBurial.Name = "cbBoxBurial";
            this.cbBoxBurial.Size = new System.Drawing.Size(121, 21);
            this.cbBoxBurial.TabIndex = 3;
            // 
            // lblGraveType
            // 
            this.lblGraveType.AutoSize = true;
            this.lblGraveType.Location = new System.Drawing.Point(28, 54);
            this.lblGraveType.Name = "lblGraveType";
            this.lblGraveType.Size = new System.Drawing.Size(50, 13);
            this.lblGraveType.TabIndex = 4;
            this.lblGraveType.Text = "Grafsoort";
            // 
            // txtBoxGraveType
            // 
            this.txtBoxGraveType.Location = new System.Drawing.Point(84, 51);
            this.txtBoxGraveType.Name = "txtBoxGraveType";
            this.txtBoxGraveType.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGraveType.TabIndex = 5;
            // 
            // Deceased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 462);
            this.Controls.Add(this.groupBoxGrave);
            this.Controls.Add(this.groupBoxDeceased);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deceased";
            this.Text = "Deceased";
            this.Load += new System.EventHandler(this.Deceased_Load);
            this.groupBoxDeceased.ResumeLayout(false);
            this.groupBoxDeceased.PerformLayout();
            this.groupBoxGrave.ResumeLayout(false);
            this.groupBoxGrave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDeceased;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.ComboBox cbBoxGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBoxGrave;
        private System.Windows.Forms.TextBox txtBoxGraveType;
        private System.Windows.Forms.Label lblGraveType;
        private System.Windows.Forms.ComboBox cbBoxBurial;
        private System.Windows.Forms.Label lblBurial;

    }
}