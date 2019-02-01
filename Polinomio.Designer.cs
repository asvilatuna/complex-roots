namespace $safeprojectname$
{
	partial class Polinomio
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polinomio));
			this.One = new System.Windows.Forms.Label();
			this.Two = new System.Windows.Forms.Label();
			this.Three = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.gc = new System.Windows.Forms.TextBox();
			this.cc = new System.Windows.Forms.TextBox();
			this.bc = new System.Windows.Forms.TextBox();
			this.ac = new System.Windows.Forms.TextBox();
			this.x = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// One
			// 
			this.One.AutoSize = true;
			this.One.Location = new System.Drawing.Point(44, 180);
			this.One.Name = "One";
			this.One.Size = new System.Drawing.Size(27, 13);
			this.One.TabIndex = 0;
			this.One.Text = "x1 =";
			// 
			// Two
			// 
			this.Two.AutoSize = true;
			this.Two.Location = new System.Drawing.Point(44, 221);
			this.Two.Name = "Two";
			this.Two.Size = new System.Drawing.Size(27, 13);
			this.Two.TabIndex = 1;
			this.Two.Text = "x2 =";
			// 
			// Three
			// 
			this.Three.AutoSize = true;
			this.Three.Location = new System.Drawing.Point(44, 261);
			this.Three.Name = "Three";
			this.Three.Size = new System.Drawing.Size(27, 13);
			this.Three.TabIndex = 2;
			this.Three.Text = "x3 =";
			this.Three.Click += new System.EventHandler(this.label3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(327, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gc
			// 
			this.gc.Location = new System.Drawing.Point(32, 53);
			this.gc.Name = "gc";
			this.gc.Size = new System.Drawing.Size(42, 20);
			this.gc.TabIndex = 6;
			// 
			// cc
			// 
			this.cc.Location = new System.Drawing.Point(99, 53);
			this.cc.Name = "cc";
			this.cc.Size = new System.Drawing.Size(42, 20);
			this.cc.TabIndex = 7;
			// 
			// bc
			// 
			this.bc.Location = new System.Drawing.Point(186, 53);
			this.bc.Name = "bc";
			this.bc.Size = new System.Drawing.Size(42, 20);
			this.bc.TabIndex = 8;
			this.bc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// ac
			// 
			this.ac.Location = new System.Drawing.Point(285, 53);
			this.ac.Name = "ac";
			this.ac.Size = new System.Drawing.Size(42, 20);
			this.ac.TabIndex = 11;
			this.ac.TextChanged += new System.EventHandler(this.d_TextChanged);
			// 
			// x
			// 
			this.x.AutoSize = true;
			this.x.Location = new System.Drawing.Point(80, 56);
			this.x.Name = "x";
			this.x.Size = new System.Drawing.Size(13, 13);
			this.x.TabIndex = 12;
			this.x.Text = "+";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(167, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "+";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(147, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "X";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(234, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "X^2";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(266, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "+";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(333, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(26, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "X^3";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new System.Drawing.Point(29, 310);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(330, 114);
			this.richTextBox1.TabIndex = 25;
			this.richTextBox1.Text = "Calcule las raíces reales o complejas de un polinomio hasta grado 6\n\n1. Ingrese l" +
    "os coeficientes del polinomio.\n\n2. Presione el botón \"Calcular\".\n\n3. Obtenga las" +
    " raíces del polinomio ingresado.";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// Polinomio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 425);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.x);
			this.Controls.Add(this.ac);
			this.Controls.Add(this.bc);
			this.Controls.Add(this.cc);
			this.Controls.Add(this.gc);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Three);
			this.Controls.Add(this.Two);
			this.Controls.Add(this.One);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Polinomio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Polinomios";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label One;
		private System.Windows.Forms.Label Two;
		private System.Windows.Forms.Label Three;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox gc;
		private System.Windows.Forms.TextBox cc;
		private System.Windows.Forms.TextBox bc;
		private System.Windows.Forms.TextBox ac;
		private System.Windows.Forms.Label x;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}