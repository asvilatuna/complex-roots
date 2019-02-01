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
using System.Collections;

namespace $safeprojectname$ 

{
    public partial class Main : Form
    {
        int n;

        Double Real;

        Double Img;

        Double O;

        Double Mod;

        Double Pi = Constants.Pi;

        Double Roots;

        int aux = 0;

        System.Drawing.Pen Lapiz;

        System.Drawing.Graphics Vector;

        Label IMG = new Label();

        Label REAL = new Label();

        ArrayList Vectors = new ArrayList();
		private int cont;

		public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }

		public Main(int cont)
		{
			this.cont = cont;
		}

		private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                if (txtImg.Text != "" & txtReal.Text != "")

                {
                    Real = Convert.ToDouble(txtReal.Text);

                    Img = Convert.ToDouble(txtImg.Text);

                    if (Real == 0 & Img > 0)
                    {
                        O = Pi / 2;
                    }
                    if (Real>0&Img==0)
                    {
                        O = 0;

                    }
                    if (Real == 0 & Img < 0)
                    {
                        O = 3 * Pi / 2;

                    }

                    if (Real < 0 & Img == 0)
                    {
                        O = Pi;

                    }

                    if (Real > 0 & Img > 0)
                    {
                        O = Math.Atan(Img / Real);

                    }

                    if (Real < 0 & Img > 0)
                    {
                        O = Math.Abs(Math.Atan(Img / Real))+Pi/2;

                    }

                    if (Real < 0 & Img < 0)
                    {
                        O = Math.Abs(Math.Atan(Img / Real))+Pi;

                    }

                    if (Real > 0 & Img < 0)
                    {
                        O =  Math.Abs(Math.Atan(Img / Real))+(3*Pi/2);

                    }


                    Mod = Math.Sqrt((Real * Real) + (Img * Img));

                    int t = Root.SelectedIndex + 1;

                    if (t <= 10)

                    {
                        n = t;

                        Roots = Math.Pow(Mod, (1 / (double)t));

                        Instrucciones();

                        Calcular();

                    }

                    else

                    {
                        Root.Enabled = false;

                        n = Convert.ToInt32(Alternative.Text);

                        Roots = Math.Pow(Mod, (1 / (double)t));      

                        Instrucciones();

                        Calcular();

                    }


                } else

                {

                    MessageBox.Show("Debes ingresar nuevos datos del número complejo","Advertencia");

                }

                



            }
            else
            {

                Borrar();

            }
            
            
            

        }

        private void Instrucciones()
        {
            Results.Text += Environment.NewLine + " Se resuelve por el Teorema de Moivre";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " Se obtienen las " + n + " raíces, evaluando";

            Results.Text += Environment.NewLine + " k, donde k = {0, 1, 2, ....., n-1} ; n = " + n;

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " 1. Calculamos el módulo del complejo";

            Results.Text += Environment.NewLine + " mediante la siguiente igualdad:";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + "             |Z| = √ZZ'        ";

            Results.Text += Environment.NewLine + "             |Z| = " + Mod;

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " obtenemos la raíz " + n + " del módulo de Z.";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + "            √|Z| = √" + Mod + "        ";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + "            √|Z| = " + Roots + "        ";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " 2. Calculamos el ángulo del complejo:";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " Θ = arctan(Img(Z)/Real(Z))+ángulo del";

            Results.Text += Environment.NewLine + " cuadrante";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " Donde Real(Z) representa a la parte real";

            Results.Text += Environment.NewLine + " de Z e Img(Z) la parte imaginaria de Z.";

            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " Entonces:";

            Results.Text += Environment.NewLine + "";

            if (Real == 0 & Img > 0)
            {
                Results.Text += Environment.NewLine + "             Θ = " + O;
            }
            if (Real > 0 & Img == 0)
            {

                Results.Text += Environment.NewLine + "             Θ = " + O;

            }
            if (Real == 0 & Img < 0)
            {

                Results.Text += Environment.NewLine + "             Θ = " + O;

            }

            if (Real < 0 & Img == 0)
            {

                Results.Text += Environment.NewLine + "             Θ = " + O;

            }

            if (Real > 0 & Img > 0)
            {
                Results.Text += Environment.NewLine + "             Θ = arctan(" + Img + "/" + Real + ")" +" + "+ "0";

                Results.Text += Environment.NewLine + "             Θ = " + O;

            }

            if (Real < 0 & Img > 0)
            {
                Results.Text += Environment.NewLine + "             Θ = |arctan(" + Img + "/" + Real + ")|" + " + " + "Pi/2";

                Results.Text += Environment.NewLine + "             Θ = " + O;

            }

            if (Real < 0 & Img < 0)
            {
                Results.Text += Environment.NewLine + "             Θ = |arctan(" + Img + "/" + Real + ")|" + " + " + "pi";

                Results.Text += Environment.NewLine + "             Θ = " + O;

            }

            if (Real > 0 & Img < 0)
            {
                Results.Text += Environment.NewLine + "             Θ = |arctan(" + Img + "/" + Real + ")|" + " + " + "3*Pi/2";

                Results.Text += Environment.NewLine + "             Θ = " + O;

            }


            Results.Text += Environment.NewLine + "";

            Results.Text += Environment.NewLine + " Así:";

            Results.Text += Environment.NewLine + "";

        }

        private void Borrar()
        {
            txtImg.Text = "";

            txtReal.Text = "";

            Results.Text = "";

            aux = 0;

            btnCalcular.Text = "Calcular";


        }

        private void Calcular()
        {

            for (int k = 0; k < n; k++)
            {

                Decimal R = decimal.Round(Convert.ToDecimal(Roots*Math.Cos(((2 * k * Pi) + O) / n)), 3, MidpointRounding.AwayFromZero);

                Decimal I = decimal.Round(Convert.ToDecimal(Roots*Math.Sin(((2 * k * Pi) + O) / n)), 3, MidpointRounding.AwayFromZero);

                float r = (float)R;

                float i = (float)I;

                int midx = 660;

                int midy = 270;

                EspacioComplejo();

                Lapiz = new System.Drawing.Pen(System.Drawing.Color.Black);

                Vector = this.CreateGraphics();

                Vector.DrawLine(Lapiz, 440, midy, 890, midy);

                Vector.DrawLine(Lapiz, midx, 500, midx, 50);

                IMG.SetBounds(645, 30, 40, 15);

                IMG.Text = "Img(Z)";

                IMG.BackColor = Color.Transparent;

                this.Controls.Add(IMG);

                REAL.SetBounds(900, midy-10, 60, 40);

                REAL.Text = "Real(Z)";

                this.Controls.Add(REAL);

                if (Roots <= 20) {

                    Lapiz.Color = System.Drawing.Color.Red;

                    Vector.DrawLine(Lapiz, midx, midy, midx + 20 * (float)Real, midy - 20 * (float)Img);

                    Lapiz.Color = System.Drawing.Color.Blue;

                    Vector.DrawLine(Lapiz, midx, midy, midx + 20*r, midy - 20*i);

                }
                else

                {
                    Lapiz.Color = System.Drawing.Color.Red;

                    Vector.DrawLine(Lapiz, midx, midy, midx + 20 * (float)Real, midy - 20 * (float)Img);

                    Lapiz.Color = System.Drawing.Color.Blue;

                    Vector.DrawLine(Lapiz, midx, midy, midx + r, midy - i);


                }


                if (R >= 0)

                {

                    if (I >= 0)


                    {
                        Results.Text += Environment.NewLine + " Evaluamos para k = " + k;

                        Results.Text += Environment.NewLine + "";

                        Results.Text += Environment.NewLine + " "+(Convert.ToString(R) + " + " + (Convert.ToString(I))) + " i";

                        Results.Text += Environment.NewLine + "";

                    }
                    else
                    {

                        Results.Text += Environment.NewLine + " Evaluamos para k = " + k;

                        Results.Text += Environment.NewLine + "";

                        Results.Text += Environment.NewLine + " " + (Convert.ToString(R) + " " + (Convert.ToString(I))) + " i";

                        Results.Text += Environment.NewLine + "";

                    }

                }
                else
                {

                    if (I >= 0)

                    {
                        Results.Text += Environment.NewLine + " Evaluamos para k = " + k;

                        Results.Text += Environment.NewLine + "";

                        Results.Text += Environment.NewLine + " " + (Convert.ToString(R) + " + " + (Convert.ToString(I))) + " i";

                        Results.Text += Environment.NewLine + "";

                    }
                    else
                    {

                        Results.Text += Environment.NewLine + " Evaluamos para k = " + k;

                        Results.Text += Environment.NewLine + "";

                        Results.Text += Environment.NewLine + " " + (Convert.ToString(R) + " " + (Convert.ToString(I))) + " i";

                        Results.Text += Environment.NewLine + "";

                    }

                }

                aux = 1;

                btnCalcular.Text = "Borrar";

                

                Vectors.Add(Convert.ToString(R) + " + " + (Convert.ToString(I)) + " i");

                

            }


        }

        private void EspacioComplejo()
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Root_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Results_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Regresar");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;

			DialogResult result;

			result = MessageBox.Show(this, "¿Desea observar las instrucciones?", "Recomendaciones", buttons,

				MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,

				MessageBoxOptions.RightAlign);


			if (result == DialogResult.Yes)
			{

				Tips Tips = new Tips();

				Tips.StartPosition = FormStartPosition.CenterScreen;

				Tips.Show();

				Tips.TopMost = true;

				Tips.Activate();
				
			}
		}

		private void Form1_Activated(object sender, EventArgs e)
        {


        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Vector.Clear(BackColor);

            IMG.Text = "";

            REAL.Text = "";

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            label7.Text = "Componente Vector: "+"(" + Real + " ; " + Img +" i"+")"+"   Coordenadas Polares: "+"("+decimal.Round(Convert.ToDecimal(Mod),2,MidpointRounding.AwayFromZero)+" ; "+decimal.Round(Convert.ToDecimal(O),3,MidpointRounding.AwayFromZero)+" rad"+")";

            label7.ForeColor = Color.Red;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Eulers Eulers = new Eulers(decimal.Round(Convert.ToDecimal(O), 2, MidpointRounding.AwayFromZero));

            Eulers.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void exportarATextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String Content = Results.Text;

            Export Export = new Export(Content);

            Export.Show();
        }

        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {


			Tips Tips = new Tips();

			Tips.Show();


		}

		private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Créditos de programación a Ramos Daniel, Torres Stalin y Rodríguez Bryan. Universidad Central del Ecuador - 2019.", "Créditos");

        }

        private void abrirSitioEnGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/asvilatuna/complex-roots");
        }

        private void referenciasToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("\nhttps://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants"+"\nhttps://code.msdn.microsoft.com/windowsapps/Radicacin-60b7f550"+"\nhttps://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.richtextbox?view=netframework-4.7.2"+"\nhttps://codigofuentenet.wordpress.com/2012/07/17/herencia-en-c/", "Referencias del Programa");

		private void cerraToolStripMenuItem_Click(object sender, EventArgs e)
		{

			this.Close();

		}

		private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Pad Pad = new Pad();

			Pad.Show();

			Pad.TopMost = true;

			Pad.Activate();

		}

		private void txtReal_TextChanged(object sender, EventArgs e)
		{


		}

		private void polinomiosToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Polinomio Polinomio = new Polinomio();

			Polinomio.Show();



		}
	}


}
