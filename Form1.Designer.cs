using System;

namespace $safeprojectname$
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Alternative = new System.Windows.Forms.TextBox();
			this.Results = new System.Windows.Forms.RichTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.Root = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtImg = new System.Windows.Forms.TextBox();
			this.txtReal = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnGraph = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarATextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarAGeoGebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.polinomiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.códigoFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirSitioEnGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.referenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingrese el número coomplejo:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Alternative);
			this.groupBox1.Controls.Add(this.Results);
			this.groupBox1.Controls.Add(this.richTextBox1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnCalcular);
			this.groupBox1.Controls.Add(this.Root);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtImg);
			this.groupBox1.Controls.Add(this.txtReal);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 504);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Raíces enésimas";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// Alternative
			// 
			this.Alternative.Location = new System.Drawing.Point(311, 65);
			this.Alternative.Name = "Alternative";
			this.Alternative.Size = new System.Drawing.Size(59, 20);
			this.Alternative.TabIndex = 13;
			this.Alternative.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Results
			// 
			this.Results.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Results.Location = new System.Drawing.Point(22, 168);
			this.Results.Name = "Results";
			this.Results.ReadOnly = true;
			this.Results.Size = new System.Drawing.Size(348, 231);
			this.Results.TabIndex = 12;
			this.Results.Text = "";
			this.Results.TextChanged += new System.EventHandler(this.Results_TextChanged);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new System.Drawing.Point(22, 415);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(348, 109);
			this.richTextBox1.TabIndex = 11;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 13);
			this.label6.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(221, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Seleccione el exponente:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(22, 109);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(348, 35);
			this.btnCalcular.TabIndex = 1;
			this.btnCalcular.Text = "Calcular y graficar";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
			// 
			// Root
			// 
			this.Root.FormattingEnabled = true;
			this.Root.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Otro"});
			this.Root.Location = new System.Drawing.Point(224, 65);
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(81, 21);
			this.Root.TabIndex = 8;
			this.Root.Text = "Raiz";
			this.Root.SelectedIndexChanged += new System.EventHandler(this.Root_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(98, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "+";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(100, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 18);
			this.label3.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(193, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "i";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtImg
			// 
			this.txtImg.Location = new System.Drawing.Point(117, 66);
			this.txtImg.Name = "txtImg";
			this.txtImg.Size = new System.Drawing.Size(70, 20);
			this.txtImg.TabIndex = 3;
			// 
			// txtReal
			// 
			this.txtReal.Location = new System.Drawing.Point(22, 66);
			this.txtReal.Name = "txtReal";
			this.txtReal.Size = new System.Drawing.Size(70, 20);
			this.txtReal.TabIndex = 2;
			this.txtReal.TextChanged += new System.EventHandler(this.txtReal_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(34, 571);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(372, 58);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Formas de expresar el vector";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(-3, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(288, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Powered by Bryan Rodríguez, Daniel Ramos y Torres Stalin";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// btnGraph
			// 
			this.btnGraph.Location = new System.Drawing.Point(31, 62);
			this.btnGraph.Name = "btnGraph";
			this.btnGraph.Size = new System.Drawing.Size(153, 35);
			this.btnGraph.TabIndex = 4;
			this.btnGraph.Text = "Vaciar gráfica";
			this.btnGraph.UseVisualStyleBackColor = true;
			this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(441, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Gráfica";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.btnGraph);
			this.groupBox3.Location = new System.Drawing.Point(422, 483);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(524, 146);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Controles";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(10, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(334, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "La gráfica es aproximada y está a escala. Úsese solo para referencia.";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(349, 62);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(153, 35);
			this.button4.TabIndex = 8;
			this.button4.Text = "Forma de Euler";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(283, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "Las raíces enésimas forma un polígono regular de n lados.";
			this.label9.Click += new System.EventHandler(this.label9_Click_1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(190, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 35);
			this.button1.TabIndex = 5;
			this.button1.Text = "Ubicar complejo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.códigoFuenteToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(952, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarATextoToolStripMenuItem,
            this.exportarAGeoGebraToolStripMenuItem,
            this.cerraToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
			// 
			// exportarATextoToolStripMenuItem
			// 
			this.exportarATextoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportarATextoToolStripMenuItem.Image")));
			this.exportarATextoToolStripMenuItem.Name = "exportarATextoToolStripMenuItem";
			this.exportarATextoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.exportarATextoToolStripMenuItem.Text = "Exportar a texto";
			this.exportarATextoToolStripMenuItem.Click += new System.EventHandler(this.exportarATextoToolStripMenuItem_Click);
			// 
			// exportarAGeoGebraToolStripMenuItem
			// 
			this.exportarAGeoGebraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportarAGeoGebraToolStripMenuItem.Image")));
			this.exportarAGeoGebraToolStripMenuItem.Name = "exportarAGeoGebraToolStripMenuItem";
			this.exportarAGeoGebraToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.exportarAGeoGebraToolStripMenuItem.Text = "Exportar a GeoGebra";
			this.exportarAGeoGebraToolStripMenuItem.Click += new System.EventHandler(this.exportarAGeoGebraToolStripMenuItem_Click);
			// 
			// cerraToolStripMenuItem
			// 
			this.cerraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerraToolStripMenuItem.Image")));
			this.cerraToolStripMenuItem.Name = "cerraToolStripMenuItem";
			this.cerraToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cerraToolStripMenuItem.Text = "Cerrar";
			this.cerraToolStripMenuItem.Click += new System.EventHandler(this.cerraToolStripMenuItem_Click);
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polinomiosToolStripMenuItem,
            this.funcionesToolStripMenuItem});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.herramientasToolStripMenuItem.Text = "Herramientas";
			// 
			// polinomiosToolStripMenuItem
			// 
			this.polinomiosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("polinomiosToolStripMenuItem.Image")));
			this.polinomiosToolStripMenuItem.Name = "polinomiosToolStripMenuItem";
			this.polinomiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.polinomiosToolStripMenuItem.Text = "Polinomios";
			this.polinomiosToolStripMenuItem.Click += new System.EventHandler(this.polinomiosToolStripMenuItem_Click);
			// 
			// funcionesToolStripMenuItem
			// 
			this.funcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionesToolStripMenuItem.Image")));
			this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
			this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.funcionesToolStripMenuItem.Text = "Caracter especial";
			this.funcionesToolStripMenuItem.Click += new System.EventHandler(this.funcionesToolStripMenuItem_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruccionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// instruccionesToolStripMenuItem
			// 
			this.instruccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("instruccionesToolStripMenuItem.Image")));
			this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
			this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.instruccionesToolStripMenuItem.Text = "Instrucciones";
			this.instruccionesToolStripMenuItem.Click += new System.EventHandler(this.instruccionesToolStripMenuItem_Click);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
			// 
			// códigoFuenteToolStripMenuItem
			// 
			this.códigoFuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirSitioEnGithubToolStripMenuItem,
            this.referenciasToolStripMenuItem});
			this.códigoFuenteToolStripMenuItem.Name = "códigoFuenteToolStripMenuItem";
			this.códigoFuenteToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.códigoFuenteToolStripMenuItem.Text = "Código Fuente";
			// 
			// abrirSitioEnGithubToolStripMenuItem
			// 
			this.abrirSitioEnGithubToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirSitioEnGithubToolStripMenuItem.Image")));
			this.abrirSitioEnGithubToolStripMenuItem.Name = "abrirSitioEnGithubToolStripMenuItem";
			this.abrirSitioEnGithubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.abrirSitioEnGithubToolStripMenuItem.Text = "Abrir sitio en Github";
			this.abrirSitioEnGithubToolStripMenuItem.Click += new System.EventHandler(this.abrirSitioEnGithubToolStripMenuItem_Click);
			// 
			// referenciasToolStripMenuItem
			// 
			this.referenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("referenciasToolStripMenuItem.Image")));
			this.referenciasToolStripMenuItem.Name = "referenciasToolStripMenuItem";
			this.referenciasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.referenciasToolStripMenuItem.Text = "Referencias";
			this.referenciasToolStripMenuItem.Click += new System.EventHandler(this.referenciasToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 659);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "$safeprojectname$";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private void exportarAGeoGebraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtImg;
        public System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Root;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.TextBox Alternative;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarATextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAGeoGebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirSitioEnGithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem polinomiosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
	}
}

