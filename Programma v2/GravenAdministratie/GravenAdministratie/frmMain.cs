using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using GravenAdministratie.zoeken;
using GravenAdministratie.Toevoegen;

namespace GravenAdministratie
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            barButtonAddSubject.AllowDrawArrow = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonGraveyard_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addSubGraveyard());
        }

        private void barButtonAddGrave_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addGrave());
        }

        private void barButtonRightfulclaimant_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addRightfull());
        }

        private void barButtonSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new AddDelevirer());
        }

        private void barButtonSearchSubject_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new searchSubject());
        }

        private void barButtonSearchDeceased_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new searchDeceased());
        }

        private void barButtonSearchGrave_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new searchGrave());
        }

        private void barButtonDeceased_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addDeceased());
        }

        private void barButtonAddDeceased_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new AddGraveyard());
        }

        private void barButtonAddDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addDocument());
        }

        private void barButtonAddArticle_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addArticle());
        }

        private void barButtonSearchDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new searchDocument());
        }

        private void barButtonSearchArticle_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new searchArticle());
        }

        private void barButtonFuneralGuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addFuneralEnt());
        }

        private void barButtonIntrested_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addInterested());
        }

        private void CreateForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(form);
            form.Show();
        }
    }
}