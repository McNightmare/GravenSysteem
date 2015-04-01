using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GravenSysteem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Password FROM Users WHERE Username = '" + txtUsername.Text + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            bool correct = false;

            while (rdr.Read())
            {
                correct = rdr.GetString(0).Trim() == txtPassword.Text;
            }
                
            conn.Close();

            if (correct)
                new frmMain().Show();
            else
            {
                MessageBox.Show("Uw login naam of wachtwoord is fout, probeer het opnieuw.");
                txtUsername.Focus();
                txtPassword.Clear();
                txtUsername.SelectAll();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }
    }
}
