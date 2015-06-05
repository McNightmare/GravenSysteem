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

namespace GravenAdministratie
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            barButtonAddSubject.AllowDrawArrow = false;
        }

        private void barButtonGraveyard_ItemClick(object sender, ItemClickEventArgs e)
        {
            //toevoegen begraafplaats
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            CreateForm(new SearchSubject());
        }

        private void barButtonSearchDeceased_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new SearchDeceased());
        }

        private void barButtonSearchGrave_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new SearchGrave());
        }

        private void barButtonDeceased_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new addDeceased());
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