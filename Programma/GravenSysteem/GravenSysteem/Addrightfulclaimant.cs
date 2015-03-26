using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GravenSysteem
{
    public partial class Addrightfulclaimant : Form
    {

        int width;
        int height;
        Point location;
        string Sqlinput;
        public Addrightfulclaimant(int width, int height, Point location)
        {
            this.width = width;
            this.height = height;
            this.location = location;
            InitializeComponent();
        }
        private void Addrightfulclaimant_Load(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
            this.Location = location;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Datastring");
            //SqlDataAdapter sda = new SqlDataAdapter("Select (datacollum) FROM (datatablo) Where {0} like'" + textBox1.Text + "%'", con, Sqlinput);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem.ToString())
            {
                case"postcode":
                    Sqlinput = "Naam database table";
                    break;
            }
        }
    }
}
