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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonAddGrave_ItemClick(object sender, ItemClickEventArgs e)
        {
            addGrave addGrave = new addGrave();
            addGrave.TopLevel = false;
            addGrave.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(addGrave);
            addGrave.Show();
        }
        private void barButtonGraveyard_ItemClick(object sender, ItemClickEventArgs e)
        {
            //toevoegen begraafplaats
        }

        private void barButtonRightfulclaimant_ItemClick(object sender, ItemClickEventArgs e)
        {
            addRightfull addRightfull = new addRightfull();
            addRightfull.TopLevel = false;
            addRightfull.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(addRightfull);
            addRightfull.Show();
        }

        private void barButtonSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddDelevirer addDeliv = new AddDelevirer();
            addDeliv.TopLevel = false;
            addDeliv.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(addDeliv);
            addDeliv.Show();
        }

        private void barButtonSearchSubject_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchSubject searchsubject = new SearchSubject();
            searchsubject.TopLevel = false;
            searchsubject.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(searchsubject);
            searchsubject.Show();

        }

        private void barButtonSearchDeceased_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchDeceased searchdeceased = new SearchDeceased();
            searchdeceased.TopLevel = false;
            searchdeceased.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(searchdeceased);
            searchdeceased.Show();
        }

        private void barButtonSearchGrave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchGrave searchgrave = new SearchGrave();
            searchgrave.TopLevel = false;
            searchgrave.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(searchgrave);
            searchgrave.Show();
        }

        private void barButtonDeceased_ItemClick(object sender, ItemClickEventArgs e)
        {
            addDeceased addDeceased = new addDeceased();
            addDeceased.TopLevel = false;
            addDeceased.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(addDeceased);
            addDeceased.Show();
        }
    }
}