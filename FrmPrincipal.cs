using System;
using System.Windows.Forms;

namespace LaboratorioCompiladores
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void limpiarControles()
        {
            this.txtArchivo.ForeColor = System.Drawing.Color.Gray;
            this.txtArchivo.Text = "Arrastre el archivo aquí para cargarlo";
            this.txtArchivo.Font = System.Data
        }

    }
}
