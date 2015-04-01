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
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string con = "Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True";
            SqlConnection test = new SqlConnection(con);
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM Test Where naam  like '"+ textBox1.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem.ToString())
            {
                case"postcode":
                    Sqlinput = "postcode";
                    break;
                case "Naam":
                    Sqlinput = "naam";
                    break;

            }
        }

        private void Addrightfulclaimant_Load_1(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
            this.Location = location;

            string test = "Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(test))
            {
                con.Open();

                using(SqlDataAdapter testadapter = new SqlDataAdapter("Select * FROM Test", con))
                {
                    DataTable t = new DataTable();
                    testadapter.Fill(t);

                    dataGridView1.DataSource = t;
                }
            }
        }
    }
}
