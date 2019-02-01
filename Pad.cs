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
	public partial class Pad : Form
	{
		public Pad()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			Double Pi = Constants.Pi;

			Number.Text = Convert.ToString(Pi);

		}

		private void button2_Click(object sender, EventArgs e)
		{

			Double E = Constants.E;

			Number.Text = Convert.ToString(E);

		}

		private void button3_Click(object sender, EventArgs e)
		{

			Double Root = Constants.two;

			Number.Text = Convert.ToString(Root);

		}

		private void button4_Click(object sender, EventArgs e)
		{

			Double Phi = Constants.phi;

			Number.Text = Convert.ToString(Phi);

		}

		private void button8_Click(object sender, EventArgs e)
		{

			if (value.Text != "" & root.Text != "")
			{
				Double Value = Convert.ToDouble(value.Text);

				Double Root = Convert.ToDouble(root.Text);

				Double Result = Math.Pow(Value, (1 / Root));

				Number.Text = Convert.ToString(Result);

			} else

			{
				Number.Text = "Debes generar una raiz real";

			}


		}

		private void button7_Click(object sender, EventArgs e)
		{

			if (value.Text != "" & root.Text != "")
			{
				Double Value = Convert.ToDouble(value.Text);

				Double Root = Convert.ToDouble(root.Text);

				Double Result = Math.Pow(Value, Root);

				Number.Text = Convert.ToString(Result);

			}
			else

			{
				Number.Text = "Debes generar un exponente real";

			}

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Number.Text);

		}

	}
}
