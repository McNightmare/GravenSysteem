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
        SqlConnection con = new SqlConnection("Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True");

        public Addrightfulclaimant(int width, int height, Point location)
        {
            this.width = width;
            this.height = height;
            this.location = location;
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem.ToString())
            {
                case"Voornaam":
                    Sqlinput = "Voornaam";
                    break;
                case"Straat":
                    Sqlinput = "Straat";
                    break;
                case "Woonplaats":
                    Sqlinput = "Woonplaats";
                    break;
                case"Gemeente":
                    Sqlinput = "Gemeente";
                    break;
                case"Land":
                    Sqlinput = "Land";
                    break;

            }
        }

        private void Addrightfulclaimant_Load_1(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
            this.Location = location;

            using (con)
            {
                con.Open();

                using(SqlDataAdapter testadapter = new SqlDataAdapter("Select * FROM Overledenen", con))
                {
                    DataTable t = new DataTable();
                    testadapter.Fill(t);

                    dataGridView1.DataSource = t;
                }
                 
            }
            con.Close();
        }
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection test = new SqlConnection("Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True");
            test.Open();
            SqlCommand cmd = test.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Overledenen Where "+Sqlinput+" like'" + textBox4.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            test.Close();
        }
    }
}
