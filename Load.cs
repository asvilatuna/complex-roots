using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
	public partial class Load : Form
	{

		public Load()
		{
			InitializeComponent();

			this.Load += Load_Load;

		}

		private void Load_Load(object sender, EventArgs e)
		{
			Contador.Start();

			Thread t = new Thread(new ThreadStart(Go));

			Loading.Enabled = true;

			this.Visible = false;

			t.Start();

			Loading.Interval = 100;

			Loading.Start();


		}

		private void Contador_Tick(object sender, EventArgs e)
		{
			if (pictureBox1.Visible == true)
			{

				pictureBox2.Visible = true;

				pictureBox1.Visible = false;

			}

			else if (pictureBox2.Visible == true)
			{

				pictureBox3.Visible = true;

				pictureBox2.Visible = false;

			}

			else if (pictureBox3.Visible == true)
			{

				pictureBox1.Visible = true;

				pictureBox3.Visible = false;

			}

		}


		private void progressBar1_Click(object sender, EventArgs e)
		{

			Main Main = new Main();

			this.Hide();

			Main.Show();

		}

		private static void Go()
		{

			
		}

		private void Loading_Tick(object sender, EventArgs e)
		{
			int x = 1;

			progressBar1.Increment(x);

			if (progressBar1.Value == 100)
			{

				Loading.Enabled = false;

				progressBar1.Visible = false;

				Main Main = new Main();

				Main.Show();

				this.Hide();

			}

			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
