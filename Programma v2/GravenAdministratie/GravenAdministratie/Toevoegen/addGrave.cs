using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GravenAdministratie
{
    public partial class addGrave : DevExpress.XtraEditors.XtraForm
    {
        public addGrave()
        {
            InitializeComponent();
        }

        private void checkBoxReserve_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReserve.Checked)
                GroupBoxReserve.Show();
            else
                GroupBoxReserve.Hide();
        }
    }
}