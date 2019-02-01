using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MathNet.Numerics;

namespace $safeprojectname$
{
	public partial class Polinomio : Form
	{
		public Polinomio()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{


			Double d = Convert.ToDouble(ac.Text);

			Double c = Convert.ToDouble(bc.Text);

			Double b = Convert.ToDouble(bc.Text);

			Double a = Convert.ToDouble(ac.Text);

			var roots = FindRoots.Cubic(d, c, b, a);

			Complex root1 = roots.Item1;

			Complex root2 = roots.Item2;

			Complex root3 = roots.Item3;

			One.Text = One.Text + " " + root1.Real + " + " + "(" + root1.Imaginary + ")"+" i";

			Two.Text = Two.Text + " " + root2.Real + " + " + "(" + root2.Imaginary + ")" + " i";

			Three.Text = Three.Text + " " + root2.Real + " + " + "(" + root3.Imaginary + ")" + " i";


		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void d_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{
					}
	}
}
