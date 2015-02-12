namespace GravenSysteem
{
    partial class frmAddGraf
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblInitails = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblDeathdate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtplace = new System.Windows.Forms.TextBox();
            this.lblplace = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(147, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(486, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(82, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naam";
            // 
            // txtLastname
            // 
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.Location = new System.Drawing.Point(147, 58);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(486, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(53, 61);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Achternaam";
            // 
            // txtInitials
            // 
            this.txtInitials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitials.Location = new System.Drawing.Point(147, 84);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(486, 20);
            this.txtInitials.TabIndex = 4;
            // 
            // lblInitails
            // 
            this.lblInitails.AutoSize = true;
            this.lblInitails.Location = new System.Drawing.Point(60, 87);
            this.lblInitails.Name = "lblInitails";
            this.lblInitails.Size = new System.Drawing.Size(57, 13);
            this.lblInitails.TabIndex = 5;
            this.lblInitails.Text = "Voorletters";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 110);
            this.dateTimePicker1.MaxDate = new System.DateTime(2015, 2, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2015, 2, 10, 0, 0, 0, 0);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(38, 117);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(83, 13);
            this.lblBirthday.TabIndex = 7;
            this.lblBirthday.Text = "Geboorte datum";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(42, 143);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(79, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "Geboorteplaats";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(147, 136);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(486, 20);
            this.txtCity.TabIndex = 9;
            // 
            // lblDeathdate
            // 
            this.lblDeathdate.AutoSize = true;
            this.lblDeathdate.Location = new System.Drawing.Point(29, 168);
            this.lblDeathdate.Name = "lblDeathdate";
            this.lblDeathdate.Size = new System.Drawing.Size(88, 13);
            this.lblDeathdate.TabIndex = 10;
            this.lblDeathdate.Text = "overlijdingsdatum";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(147, 162);
            this.dateTimePicker2.MinDate = new System.DateTime(2015, 2, 10, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(871, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Location = new System.Drawing.Point(147, 188);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(486, 20);
            this.txtStreet.TabIndex = 15;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(82, 191);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 16;
            this.lblStreet.Text = "Straat";
            // 
            // txtplace
            // 
            this.txtplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtplace.Location = new System.Drawing.Point(147, 215);
            this.txtplace.Name = "txtplace";
            this.txtplace.Size = new System.Drawing.Size(486, 20);
            this.txtplace.TabIndex = 17;
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.Location = new System.Drawing.Point(81, 221);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(36, 13);
            this.lblplace.TabIndex = 18;
            this.lblplace.Text = "Plaats";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(66, 245);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(51, 13);
            this.lblZipcode.TabIndex = 19;
            this.lblZipcode.Text = "postcode";
            // 
            // txtZipcode
            // 
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZipcode.Location = new System.Drawing.Point(147, 242);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(486, 20);
            this.txtZipcode.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(147, 269);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(486, 20);
            this.txtPhone.TabIndex = 21;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(35, 271);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(86, 13);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Telefoonnummer";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(85, 298);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(31, 13);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "Land";
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Location = new System.Drawing.Point(147, 298);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(486, 20);
            this.txtCountry.TabIndex = 24;
            // 
            // frmAddGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 462);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.lblplace);
            this.Controls.Add(this.txtplace);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblDeathdate);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblInitails);
            this.Controls.Add(this.txtInitials);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddGraf";
            this.Load += new System.EventHandler(this.frmAddGraf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblDeathdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtplace;
        private System.Windows.Forms.Label lblplace;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;

    }
}