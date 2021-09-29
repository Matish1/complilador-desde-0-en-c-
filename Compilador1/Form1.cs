using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador1
{
    public partial class frmEditor : Form
    {
        string archivo;
        public frmEditor()
        {
            InitializeComponent();
        }

         private void OpNuevo_Click(object sender, EventArgs e)
        {
            rteditor.Clear();
            archivo = null;
        }

        private void OpAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "MingC | *.c";

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                archivo = abrirArchivo.FileName;
                using (System.IO.StreamReader sr = new System.IO.StreamReader(archivo))
                {
                    rteditor.Text = sr.ReadToEnd();
                }
                frmEditor.ActiveForm.Text = "MingC | " + archivo;
            }
        }


        private void OpGuardar_Click(object sender, EventArgs e)
        {
            OpenFileDialog guardarArchivo = new OpenFileDialog();
            guardarArchivo.Filter = "MingC | *.c";
            if (archivo != null)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(archivo))
                {
                    sw.Write(rteditor.Text);
                }
            }
            else
            {
                if (guardarArchivo.ShowDialog() == DialogResult.OK)
                {
                    archivo = guardarArchivo.FileName;
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(archivo))
                    {
                        sw.Write(rteditor.Text);
                    }
                }
            }
        }

        private void OpGuardarComo_Click(object sender, EventArgs e)
        {
            OpenFileDialog guardarcomo = new OpenFileDialog()
            {
                Title = "Guardar Como: ",
                Filter = "MingC | *.c",
                AddExtension = true
        };
            guardarcomo.ShowDialog();
            if (archivo != null && guardarcomo.FileName != string.Empty)
            {
                archivo = guardarcomo.FileName;

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(archivo))
                {
                    sw.Write(rteditor.Text);
                    frmEditor.ActiveForm.Text = "MingC | " + archivo;
                    sw.Close();
                }
            }
        }
        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        // Este es el codigo de compilacion
        private void etCompilar_Click(object sender, EventArgs e)
        { 
            AnalizadorLexico al = new AnalizadorLexico();
            List<string> lstTokens = al.AnalisisLex(rteditor.Text);

            lstTokens.Insert(0, "\n");
            foreach(string s in lstTokens)
            {
                rteditor.Text += 5 + '\n';
            }
        }
    }
}













