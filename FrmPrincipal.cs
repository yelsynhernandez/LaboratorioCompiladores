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
        Ajuste ajuste = new Ajuste();

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblAutor.Text = "Carnet: 9490-17-969. Nombre: Yelsyn Hernández. Curso: Compiladores";
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
                                txtContenidoArchivo.AppendText($"{linea}\r\n");
                            }
                        }
                    }
                    txtContenidoArchivo.Text.TrimEnd('\r','\n');
                    Analizador analizador = new Analizador();
                    //Con recursividad
                    analizador.DistribuirContenido(txtContenidoArchivo, dgvVariables, dgvTerminales);
                    analizador.GenerarMatrizProducciones(txtContenidoArchivo, dgvProducciones);
                    
                    //Sin recursividad
                    analizador.RemoverRecursividad(txtContenidoArchivo, txtGramaticaSinRecursividad);
                    analizador.DistribuirContenido(txtGramaticaSinRecursividad, dgvVariablesSinRecursividad, dgvTerminalesSinRecursividad);
                    string gramaticaAjustada = analizador.AjustarGramatica(txtGramaticaSinRecursividad.Text);
                    txtGramaticaSinRecursividad.Text = gramaticaAjustada;
                    analizador.GenerarMatrizProducciones(txtGramaticaSinRecursividad, dgvGramaticaSinRecursividad);
                    analizador.FuncionPrimero(dgvGramaticaSinRecursividad, dgvTerminalesSinRecursividad, dgvGramaticaSinRecursividad, dgvFuncionPrimero);
                    analizador.FuncionSiguiente(txtGramaticaSinRecursividad, dgvGramaticaSinRecursividad,dgvFuncionPrimero, dgvFuncionSiguiente);

                    //Se da formato al a tabla de símbolos
                    ajuste.DimensionarTabla(dgvVariablesSinRecursividad, dgvTerminalesSinRecursividad, dgvTablaSimbolos);
                    analizador.GenerarTablaSimbolos(txtGramaticaSinRecursividad, dgvGramaticaSinRecursividad, dgvTablaSimbolos, dgvFuncionPrimero, dgvFuncionSiguiente);
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
            string fuente = "Times New Roman";
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
            txtGramaticaSinRecursividad.Clear();

            dgvVariables.Rows.Clear();
            dgvTerminales.Rows.Clear();
            dgvVariablesSinRecursividad.Rows.Clear();
            dgvTerminalesSinRecursividad.Rows.Clear();
            dgvProducciones.DataSource = null;
            dgvGramaticaSinRecursividad.DataSource = null;
            dgvFuncionPrimero.DataSource = null;
            dgvFuncionSiguiente.DataSource = null;
            dgvTablaSimbolos.Rows.Clear();
            dgvTablaSimbolos.Columns.Clear();
            
            dgvVariables.Columns[0].HeaderText = "Variables";
            dgvTerminales.Columns[0].HeaderText = "Terminales";
            dgvVariablesSinRecursividad.Columns[0].HeaderText = "Variables";
            dgvTerminalesSinRecursividad.Columns[0].HeaderText = "Terminales";
            TextoDefecto(true);
        }
    }
}
