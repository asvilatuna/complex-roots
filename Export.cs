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
    public partial class Export : Form
    {

        String UseContent;

        public Export(String Content)

        {
            InitializeComponent();

            UseContent = Content;


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e )

        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Archivo de Texto|*.txt|Archivo de Texto|";

            saveFileDialog1.Title = "Guardar archivo";

            saveFileDialog1.FileName = "Complex - Export.txt";

            saveFileDialog1.ShowDialog();

            String Path = saveFileDialog1.FileName
                ;
            System.IO.File.WriteAllText(Path, UseContent);

            MessageBox.Show("Se ha exportado con éxito", "Fichero Exportado");

            Close();

        }
    }
}
