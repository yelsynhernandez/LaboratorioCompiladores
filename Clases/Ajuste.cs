using System.Drawing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace LaboratorioCompiladores.Clases
{
    internal class Ajuste
    {
        public void FormatoDataGrid(DataGridView dgv, bool limpiarTitulos = true)
        {
            if(limpiarTitulos)
            {
                foreach (DataGridViewColumn columna in dgv.Columns)
                {
                    columna.HeaderText = String.Empty;
                }
                dgv.Columns[0].HeaderText = "Variable";
            }

            //Configuracion visual de la tabla
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            dgv.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            for (int columna = 0; columna < dgv.ColumnCount; columna++)
            {
                dgv.Columns[columna].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[columna].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int fila = 0; fila < dgv.Rows.Count; fila++)
            {
                if (fila % 2 == 0)
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E9ECEF");
                }
                else
                {
                    dgv.Rows[fila].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CED4DA");
                }
            }

            dgv.RowHeadersVisible = false;

            style.ForeColor = ColorTranslator.FromHtml("#212529");
            dgv.DefaultCellStyle = style;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#BFC2C4");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            dgv.EnableHeadersVisualStyles = false;
        }

        public void DimensionarTabla(DataGridView dgvVariables, DataGridView dgvTerminales, DataGridView dgvTablaSimbolos)
        {
            dgvTablaSimbolos.Columns.Clear();

            DataGridViewTextBoxColumn colBlanca = new DataGridViewTextBoxColumn { HeaderText = "", Name = "variables" };
            DataGridViewTextBoxColumn colFinLinea = new DataGridViewTextBoxColumn { HeaderText = "$", Name = "columnaFinLinea" };
            
            dgvTablaSimbolos.Columns.Add(colBlanca);
            // Agregar columnas con títulos tomados de los terminales
            foreach (DataGridViewRow row in dgvTerminales.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string terminal = row.Cells[0].Value.ToString();
                    DataGridViewTextBoxColumn colTerminal = new DataGridViewTextBoxColumn
                    {
                        HeaderText = terminal,
                        Name = "col" + terminal
                    };
                    dgvTablaSimbolos.Columns.Add(colTerminal);
                }
            }
            dgvTablaSimbolos.Columns[dgvTablaSimbolos.Columns.Count - 1].HeaderText = ")";
            dgvTablaSimbolos.Columns.Add(colFinLinea);

            // Agregar filas con valores tomados de las variables
            foreach (DataGridViewRow row in dgvVariables.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string variable = row.Cells[0].Value.ToString();
                    dgvTablaSimbolos.Rows.Add(variable);
                }
            }

            // Ajustar el tamaño de las columnas para que se ajusten al contenido
            dgvTablaSimbolos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FormatoDataGrid(dgvTablaSimbolos, false);
        }

        public void EscribirResultadosFuncion(List<string> lista, DataGridView dgv)
        {
            DataTable dt = new DataTable();
            int columnas = 0;
            int maximoColumnas;
            for (int i = 0; i < lista.Count; i++)
            {
                string[] elemento = lista[i].Split(',');
                if (elemento.Length > columnas)
                {
                    maximoColumnas = elemento.Length;
                    while (columnas < maximoColumnas)
                    {
                        dt.Columns.Add(String.Empty);
                        columnas++;
                    }
                }
                DataRow dr = dt.NewRow();
                for (int columna = 0; columna < elemento.Length; columna++)
                {
                    dr[columna] = elemento[columna];
                }
                dt.Rows.Add(dr);
            }

            dgv.DataSource = dt;
            FormatoDataGrid(dgv);
        }
    }
}
