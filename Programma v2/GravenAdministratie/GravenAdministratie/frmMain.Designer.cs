namespace GravenAdministratie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonAddDeceased = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddGrave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSearchSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSearchDeceased = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSearchGrave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSearchDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddArticle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSearchArticle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonReportsPerGrave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonReportsPerDeceased = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonReportsPerSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonStandardLetter = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonStandardSummary = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddSubject = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonGraveyard = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonFuneralGuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonIntrested = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDeceased = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRightfulclaimant = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonSubject = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGroupAdd = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupStandard = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu3 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu4 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 544);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1089, 27);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonAddDeceased,
            this.barButtonAddGrave,
            this.barButtonSearchSubject,
            this.barButtonSearchDeceased,
            this.barButtonSearchGrave,
            this.barButtonAddDocument,
            this.barButtonSearchDocument,
            this.barButtonAddArticle,
            this.barButtonSearchArticle,
            this.barButtonReportsPerGrave,
            this.barButtonReportsPerDeceased,
            this.barButtonReportsPerSubject,
            this.barButtonStandardLetter,
            this.barButtonStandardSummary,
            this.barButtonItem1,
            this.barButtonAddSubject,
            this.barButtonGraveyard,
            this.barButtonFuneralGuy,
            this.barButtonIntrested,
            this.barButtonSupplier,
            this.barButtonDeceased,
            this.barButtonRightfulclaimant});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonSubject,
            this.ribbonReports});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(1089, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonAddDeceased
            // 
            this.barButtonAddDeceased.Caption = "Overledene";
            this.barButtonAddDeceased.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonAddDeceased.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddDeceased.Glyph")));
            this.barButtonAddDeceased.Id = 7;
            this.barButtonAddDeceased.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddDeceased.LargeGlyph")));
            this.barButtonAddDeceased.Name = "barButtonAddDeceased";
            this.barButtonAddDeceased.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonAddGrave
            // 
            this.barButtonAddGrave.Caption = "Graf";
            this.barButtonAddGrave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonAddGrave.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddGrave.Glyph")));
            this.barButtonAddGrave.Id = 8;
            this.barButtonAddGrave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddGrave.LargeGlyph")));
            this.barButtonAddGrave.Name = "barButtonAddGrave";
            this.barButtonAddGrave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonAddGrave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAddGrave_ItemClick);
            // 
            // barButtonSearchSubject
            // 
            this.barButtonSearchSubject.Caption = "Subject";
            this.barButtonSearchSubject.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonSearchSubject.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchSubject.Glyph")));
            this.barButtonSearchSubject.Id = 9;
            this.barButtonSearchSubject.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchSubject.LargeGlyph")));
            this.barButtonSearchSubject.Name = "barButtonSearchSubject";
            this.barButtonSearchSubject.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonSearchSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSearchSubject_ItemClick);
            // 
            // barButtonSearchDeceased
            // 
            this.barButtonSearchDeceased.Caption = "Overledene";
            this.barButtonSearchDeceased.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonSearchDeceased.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchDeceased.Glyph")));
            this.barButtonSearchDeceased.Id = 10;
            this.barButtonSearchDeceased.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchDeceased.LargeGlyph")));
            this.barButtonSearchDeceased.Name = "barButtonSearchDeceased";
            this.barButtonSearchDeceased.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonSearchDeceased.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSearchDeceased_ItemClick);
            // 
            // barButtonSearchGrave
            // 
            this.barButtonSearchGrave.Caption = "Graf";
            this.barButtonSearchGrave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonSearchGrave.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchGrave.Glyph")));
            this.barButtonSearchGrave.Id = 11;
            this.barButtonSearchGrave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchGrave.LargeGlyph")));
            this.barButtonSearchGrave.Name = "barButtonSearchGrave";
            this.barButtonSearchGrave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonSearchGrave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSearchGrave_ItemClick);
            // 
            // barButtonAddDocument
            // 
            this.barButtonAddDocument.Caption = "Document";
            this.barButtonAddDocument.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonAddDocument.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddDocument.Glyph")));
            this.barButtonAddDocument.Id = 12;
            this.barButtonAddDocument.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddDocument.LargeGlyph")));
            this.barButtonAddDocument.Name = "barButtonAddDocument";
            // 
            // barButtonSearchDocument
            // 
            this.barButtonSearchDocument.Caption = "Document";
            this.barButtonSearchDocument.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonSearchDocument.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchDocument.Glyph")));
            this.barButtonSearchDocument.Id = 13;
            this.barButtonSearchDocument.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchDocument.LargeGlyph")));
            this.barButtonSearchDocument.Name = "barButtonSearchDocument";
            // 
            // barButtonAddArticle
            // 
            this.barButtonAddArticle.Caption = "Artikel";
            this.barButtonAddArticle.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonAddArticle.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddArticle.Glyph")));
            this.barButtonAddArticle.Id = 14;
            this.barButtonAddArticle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddArticle.LargeGlyph")));
            this.barButtonAddArticle.Name = "barButtonAddArticle";
            // 
            // barButtonSearchArticle
            // 
            this.barButtonSearchArticle.Caption = "Artikel";
            this.barButtonSearchArticle.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonSearchArticle.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchArticle.Glyph")));
            this.barButtonSearchArticle.Id = 15;
            this.barButtonSearchArticle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSearchArticle.LargeGlyph")));
            this.barButtonSearchArticle.Name = "barButtonSearchArticle";
            // 
            // barButtonReportsPerGrave
            // 
            this.barButtonReportsPerGrave.ActAsDropDown = true;
            this.barButtonReportsPerGrave.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonReportsPerGrave.Caption = "Per Graf";
            this.barButtonReportsPerGrave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonReportsPerGrave.Id = 19;
            this.barButtonReportsPerGrave.Name = "barButtonReportsPerGrave";
            this.barButtonReportsPerGrave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonReportsPerDeceased
            // 
            this.barButtonReportsPerDeceased.ActAsDropDown = true;
            this.barButtonReportsPerDeceased.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonReportsPerDeceased.Caption = "Per Overledene";
            this.barButtonReportsPerDeceased.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonReportsPerDeceased.Id = 20;
            this.barButtonReportsPerDeceased.Name = "barButtonReportsPerDeceased";
            this.barButtonReportsPerDeceased.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonReportsPerSubject
            // 
            this.barButtonReportsPerSubject.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonReportsPerSubject.Caption = "Per Subject";
            this.barButtonReportsPerSubject.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonReportsPerSubject.Id = 21;
            this.barButtonReportsPerSubject.Name = "barButtonReportsPerSubject";
            this.barButtonReportsPerSubject.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonStandardLetter
            // 
            this.barButtonStandardLetter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonStandardLetter.Caption = "Brieven";
            this.barButtonStandardLetter.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonStandardLetter.Id = 22;
            this.barButtonStandardLetter.Name = "barButtonStandardLetter";
            this.barButtonStandardLetter.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonStandardSummary
            // 
            this.barButtonStandardSummary.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonStandardSummary.Caption = "Overzichten";
            this.barButtonStandardSummary.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonStandardSummary.Id = 23;
            this.barButtonStandardSummary.Name = "barButtonStandardSummary";
            this.barButtonStandardSummary.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem1.Id = 25;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonAddSubject
            // 
            this.barButtonAddSubject.ActAsDropDown = true;
            this.barButtonAddSubject.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonAddSubject.Caption = "Subject";
            this.barButtonAddSubject.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonAddSubject.DropDownControl = this.popupMenu1;
            this.barButtonAddSubject.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddSubject.Glyph")));
            this.barButtonAddSubject.Id = 26;
            this.barButtonAddSubject.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonAddSubject.LargeGlyph")));
            this.barButtonAddSubject.Name = "barButtonAddSubject";
            this.barButtonAddSubject.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonGraveyard);
            this.popupMenu1.ItemLinks.Add(this.barButtonFuneralGuy);
            this.popupMenu1.ItemLinks.Add(this.barButtonIntrested);
            this.popupMenu1.ItemLinks.Add(this.barButtonSupplier);
            this.popupMenu1.ItemLinks.Add(this.barButtonDeceased);
            this.popupMenu1.ItemLinks.Add(this.barButtonRightfulclaimant);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // barButtonGraveyard
            // 
            this.barButtonGraveyard.Caption = "Begraafplaats";
            this.barButtonGraveyard.Id = 1;
            this.barButtonGraveyard.Name = "barButtonGraveyard";
            this.barButtonGraveyard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonGraveyard_ItemClick);
            // 
            // barButtonFuneralGuy
            // 
            this.barButtonFuneralGuy.Caption = "Begrafenis Ondernemer";
            this.barButtonFuneralGuy.Id = 2;
            this.barButtonFuneralGuy.Name = "barButtonFuneralGuy";
            // 
            // barButtonIntrested
            // 
            this.barButtonIntrested.Caption = "Belanghebbende";
            this.barButtonIntrested.Id = 3;
            this.barButtonIntrested.Name = "barButtonIntrested";
            // 
            // barButtonSupplier
            // 
            this.barButtonSupplier.Caption = "Leverancier";
            this.barButtonSupplier.Id = 4;
            this.barButtonSupplier.Name = "barButtonSupplier";
            this.barButtonSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSupplier_ItemClick);
            // 
            // barButtonDeceased
            // 
            this.barButtonDeceased.Caption = "Overledene";
            this.barButtonDeceased.Id = 5;
            this.barButtonDeceased.Name = "barButtonDeceased";
            this.barButtonDeceased.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDeceased_ItemClick);
            // 
            // barButtonRightfulclaimant
            // 
            this.barButtonRightfulclaimant.Caption = "Rechthebbende";
            this.barButtonRightfulclaimant.Id = 6;
            this.barButtonRightfulclaimant.Name = "barButtonRightfulclaimant";
            this.barButtonRightfulclaimant.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRightfulclaimant_ItemClick);
            // 
            // ribbonSubject
            // 
            this.ribbonSubject.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGroupAdd,
            this.ribbonPageSearch});
            this.ribbonSubject.Name = "ribbonSubject";
            this.ribbonSubject.Text = "Bestand";
            // 
            // ribbonGroupAdd
            // 
            this.ribbonGroupAdd.ItemLinks.Add(this.barButtonAddSubject);
            this.ribbonGroupAdd.ItemLinks.Add(this.barButtonAddDeceased);
            this.ribbonGroupAdd.ItemLinks.Add(this.barButtonAddGrave);
            this.ribbonGroupAdd.ItemLinks.Add(this.barButtonAddDocument);
            this.ribbonGroupAdd.ItemLinks.Add(this.barButtonAddArticle);
            this.ribbonGroupAdd.Name = "ribbonGroupAdd";
            this.ribbonGroupAdd.Text = "Toevoegen";
            // 
            // ribbonPageSearch
            // 
            this.ribbonPageSearch.ItemLinks.Add(this.barButtonSearchSubject);
            this.ribbonPageSearch.ItemLinks.Add(this.barButtonSearchDeceased);
            this.ribbonPageSearch.ItemLinks.Add(this.barButtonSearchGrave);
            this.ribbonPageSearch.ItemLinks.Add(this.barButtonSearchDocument);
            this.ribbonPageSearch.ItemLinks.Add(this.barButtonSearchArticle);
            this.ribbonPageSearch.Name = "ribbonPageSearch";
            this.ribbonPageSearch.Text = "Zoeken";
            // 
            // ribbonReports
            // 
            this.ribbonReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupReports,
            this.ribbonGroupStandard});
            this.ribbonReports.Name = "ribbonReports";
            this.ribbonReports.Text = "Rapporten";
            // 
            // ribbonPageGroupReports
            // 
            this.ribbonPageGroupReports.ItemLinks.Add(this.barButtonReportsPerGrave);
            this.ribbonPageGroupReports.ItemLinks.Add(this.barButtonReportsPerDeceased);
            this.ribbonPageGroupReports.ItemLinks.Add(this.barButtonReportsPerSubject);
            this.ribbonPageGroupReports.Name = "ribbonPageGroupReports";
            this.ribbonPageGroupReports.Text = "Rapporten";
            // 
            // ribbonGroupStandard
            // 
            this.ribbonGroupStandard.ItemLinks.Add(this.barButtonStandardLetter);
            this.ribbonGroupStandard.ItemLinks.Add(this.barButtonStandardSummary);
            this.ribbonGroupStandard.Name = "ribbonGroupStandard";
            this.ribbonGroupStandard.Text = "Standaard";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 144);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1089, 420);
            this.pnlMain.TabIndex = 1;
            // 
            // popupMenu2
            // 
            this.popupMenu2.Name = "popupMenu2";
            this.popupMenu2.Ribbon = this.ribbon;
            // 
            // popupMenu3
            // 
            this.popupMenu3.Name = "popupMenu3";
            this.popupMenu3.Ribbon = this.ribbon;
            // 
            // popupMenu4
            // 
            this.popupMenu4.Name = "popupMenu4";
            this.popupMenu4.Ribbon = this.ribbon;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 564);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravenadministratie - v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonSubject;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonAddDeceased;
        private DevExpress.XtraBars.BarButtonItem barButtonAddGrave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageSearch;
        private DevExpress.XtraBars.BarButtonItem barButtonSearchSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonSearchDeceased;
        private DevExpress.XtraBars.BarButtonItem barButtonSearchGrave;
        private DevExpress.XtraBars.BarButtonItem barButtonAddDocument;
        private DevExpress.XtraBars.BarButtonItem barButtonSearchDocument;
        private DevExpress.XtraBars.BarButtonItem barButtonAddArticle;
        private DevExpress.XtraBars.BarButtonItem barButtonSearchArticle;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupStandard;
        private DevExpress.XtraBars.BarButtonItem barButtonReportsPerGrave;
        private DevExpress.XtraBars.BarButtonItem barButtonReportsPerDeceased;
        private DevExpress.XtraBars.BarButtonItem barButtonReportsPerSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonStandardLetter;
        private DevExpress.XtraBars.BarButtonItem barButtonStandardSummary;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonAddSubject;
        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonGraveyard;
        private DevExpress.XtraBars.BarButtonItem barButtonFuneralGuy;
        private DevExpress.XtraBars.BarButtonItem barButtonIntrested;
        private DevExpress.XtraBars.BarButtonItem barButtonSupplier;
        private DevExpress.XtraBars.BarButtonItem barButtonDeceased;
        private DevExpress.XtraBars.BarButtonItem barButtonRightfulclaimant;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.PopupMenu popupMenu3;
        private DevExpress.XtraBars.PopupMenu popupMenu4;
    }
}