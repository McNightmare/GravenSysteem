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
    }
}