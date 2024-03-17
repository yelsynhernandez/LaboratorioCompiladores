using LaboratorioCompiladores.Clases;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LaboratorioCompiladores
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        
        private void TxtArchivo_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

                    if (archivos.Length == 1 && Path.GetExtension(archivos[0]).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtArchivo_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (Path.GetExtension(archivos[0]).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    string linea = "";
                    var fs = new FileStream(archivos[0], FileMode.Open, FileAccess.Read);

                    LimpiarControles();
                    TextoDefecto(false);
                    txtArchivo.Text = archivos[0];

                    using (var sr = new StreamReader(fs))
                    {
                        while ((linea = sr.ReadLine()) != null)
                        {
                            if(linea.Length > 0)
                            {
                                txtContenidoArchivo.Text += $"{linea}\r\n";
                            }
                        }
                    }
                    Analizador analizador = new Analizador();
                    analizador.DistribuirContenido(txtContenidoArchivo, txtVariables, txtTerminales);
                }
                else
                {
                    MessageBox.Show("Por favor, arrastra un archivo de texto (.txt).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void TextoDefecto(bool defecto)
        {
            string fuente = "Arial";
            float tamanio = 12F;

            if (defecto)
            {
                txtArchivo.Font = new Font(fuente, tamanio, FontStyle.Italic, GraphicsUnit.Point);
                txtArchivo.Text = "Arrastre aquí el archivo de texto";
                txtArchivo.ForeColor = ColorTranslator.FromHtml("#6C757D");
            }
            else
            {
                txtArchivo.Font = new Font(fuente, tamanio, FontStyle.Regular, GraphicsUnit.Point);
                txtArchivo.Clear();
                txtArchivo.ForeColor = ColorTranslator.FromHtml("#343A40");
            }
        }

        private void LimpiarControles()
        {
            txtContenidoArchivo.Clear();
            txtVariables.Clear();
            txtTerminales.Clear();
            TextoDefecto(true);
        }
    }
}
