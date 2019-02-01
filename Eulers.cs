using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Eulers : Form
    {
        decimal UseO;

        public Eulers(decimal O)
        {
            InitializeComponent();

            UseO = O;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Eulers_Load(object sender, EventArgs e)
        {

            label2.Text = "i" + "("+UseO+")";

            label5.Text = "cos(" + UseO + ") " + "+" + "sin(" + UseO + ")" + "i";

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
