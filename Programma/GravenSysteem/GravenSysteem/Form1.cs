using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GravenSysteem
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void pnlFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ResizeForm()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

            foreach (Panel pnl in this.Controls)
            {
                pnl.Width = this.Width;
                if (pnl.Name == "pnlMain")
                {
                    pnl.Height = this.Height - pnl.Location.Y;
                    foreach (Form fm in pnlMain.Controls)
                    {
                        fm.Height = pnl.Height;
                    }
                }
            }

            foreach (TabControl tab in pnlMenuBar.Controls)
            {
                tab.Width = this.Width + 10;
            }
        }

        private void pnlFrame_DoubleClick(object sender, EventArgs e)
        {         
            ResizeForm();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            Subject s = new Subject(pnlMain.Width, pnlMain.Height, pnlMain.Location);
            s.TopLevel = false;
            s.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(s);
            s.Show();
        }

        private void btnAddGraf_Click(object sender, EventArgs e)
        {
            Deceased d = new Deceased(pnlMain.Width, pnlMain.Height, pnlMain.Location);
            d.TopLevel = false;
            d.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(d);
            d.Show();
        }
    }
}
