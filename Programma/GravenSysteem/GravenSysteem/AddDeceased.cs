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
    public partial class AddDeceased : Form
    {
        int width;
        int height;
        Point location;

        public AddDeceased()
        {
            InitializeComponent();
        }

        public AddDeceased(int width, int height, Point location)
        {
            this.width = width;
            this.height = height;
            this.location = location;
            InitializeComponent();
        }
        private void AddDeaceased_Load(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
            this.Location = location;
        }

        private void AddDeceased_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = System.DateTime.Today;
            dateTimePicker2.MaxDate = System.DateTime.Today;
        }

        private void btnOverledenen_Click(object sender, EventArgs e)
        {
            SqlConnection test = new SqlConnection("Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True");
            test.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Overledenen (Voornaam,Straat,Woonplaats,Gemeente,Land)" + " VALUES (@Voornaam,@Straat,@Woonplaats,@Gemeente,@Land)", test);
            cmd.Parameters.AddWithValue("@Voornaam", textBox1.Text);
            cmd.Parameters.AddWithValue("@Straat", textBox5.Text);
            cmd.Parameters.AddWithValue("@Woonplaats",textBox10.Text);
            cmd.Parameters.AddWithValue("@Gemeente", textBox11.Text);
            cmd.Parameters.AddWithValue("@Land", textBox12.Text);
            cmd.ExecuteNonQuery();

            
        }
    }
}