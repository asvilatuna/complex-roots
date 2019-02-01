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
	public partial class Tips : Form
	{
		public Tips()
		{
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

			InitializeComponent();

			this.Load += Tips_Load;

			ocho.Visible = false;

			siete.Visible = false;

			seis.Visible = false;

			cinco.Visible = false;

			cuatro.Visible = false;

			tres.Visible = false;

			dos.Visible = false;

			uno.Visible = true;

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void ocho_Click(object sender, EventArgs e)
		{

		}

		private void tres_Click(object sender, EventArgs e)
		{

		}

		private void Tips_Load(object sender, EventArgs e)
		{

			Contador.Start();

		}

		private void Contador_Tick(object sender, EventArgs e)
		{

			if (uno.Visible == true)
			{

				dos.Visible = true;

				uno.Visible = false;

			} else if (dos.Visible == true)
			{

				tres.Visible = true;

				dos.Visible = false;

			} else if (tres.Visible == true)
			{

				cuatro.Visible = true;

				tres.Visible = false;

			} else if (cuatro.Visible == true)
			{

				cinco.Visible = true;

				cuatro.Visible = false;

			} else if (cinco.Visible == true)
			{

				seis.Visible = true;

				cinco.Visible = false;

			} else if (seis.Visible == true)
			{

				siete.Visible = true;

				seis.Visible = false;

			} else if (siete.Visible == true)
			{

				ocho.Visible = true;

				siete.Visible = false;

			} else if (ocho.Visible == true)
			{

				uno.Visible = true;

				ocho.Visible = false;

			}

		}
	}
}
