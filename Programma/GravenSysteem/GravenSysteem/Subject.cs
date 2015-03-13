using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GravenSysteem
{
    public partial class frmSubject : Form
    {
        int width;
        int height;
        Point location;

        public frmSubject()
        {
            InitializeComponent();


        }

        public frmSubject(int width, int height, Point location)
        {
            this.width = width;
            this.height = height;
            this.location = location;
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
            this.Location = location;
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbSubject.SelectedItem.ToString())
            {
                case"Overledene":
                AddDeceased Dec = new AddDeceased(pnlSubject.Width, pnlSubject.Height, pnlSubject.Location);
                Dec.TopLevel = false;
                Dec.Dock = DockStyle.Fill;
                pnlSubject.Controls.Clear();
                pnlSubject.Controls.Add(Dec);
                Dec.Show();
                break;

                case"Leverancier":
                addLeverancier lev= new addLeverancier(pnlSubject.Width, pnlSubject.Height, pnlSubject.Location);
                lev.TopLevel = false;
                lev.Dock = DockStyle.Fill;
                pnlSubject.Controls.Clear();
                pnlSubject.Controls.Add(lev);
                lev.Show();
                break;
            }
        }
    }
}