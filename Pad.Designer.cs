namespace $safeprojectname$
{
	partial class Pad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pad));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.Number = new System.Windows.Forms.Label();
			this.value = new System.Windows.Forms.TextBox();
			this.root = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(57, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "Pi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(75, 73);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(57, 38);
			this.button2.TabIndex = 1;
			this.button2.Text = "e";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(138, 73);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(57, 38);
			this.button3.TabIndex = 2;
			this.button3.Text = "√2";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(201, 73);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(57, 38);
			this.button4.TabIndex = 3;
			this.button4.Text = "φ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(140, 126);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(57, 21);
			this.button8.TabIndex = 7;
			this.button8.Text = "Raiz";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// Number
			// 
			this.Number.Location = new System.Drawing.Point(49, 30);
			this.Number.Name = "Number";
			this.Number.Size = new System.Drawing.Size(175, 13);
			this.Number.TabIndex = 8;
			this.Number.Text = "\"Se mostrará el caracter ingresado\"";
			this.Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// value
			// 
			this.value.Location = new System.Drawing.Point(13, 128);
			this.value.Name = "value";
			this.value.Size = new System.Drawing.Size(57, 20);
			this.value.TabIndex = 9;
			// 
			// root
			// 
			this.root.Location = new System.Drawing.Point(75, 128);
			this.root.Name = "root";
			this.root.Size = new System.Drawing.Size(57, 20);
			this.root.TabIndex = 10;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(13, 166);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(245, 35);
			this.button5.TabIndex = 11;
			this.button5.Text = "Copiar al portapapeles";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(201, 126);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(57, 21);
			this.button7.TabIndex = 13;
			this.button7.Text = "Exp";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Pad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 219);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.root);
			this.Controls.Add(this.value);
			this.Controls.Add(this.Number);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Pad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pad";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label Number;
		private System.Windows.Forms.TextBox value;
		private System.Windows.Forms.TextBox root;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button7;
	}
}