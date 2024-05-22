using System.Drawing;
using System;
using System.Windows.Forms;

namespace LaboratorioCompiladores.Clases
{
    internal class Ajuste
    {
        public void FormatoDataGrid(DataGridView dgv)
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                columna.HeaderText = String.Empty;
            }
            dgv.Columns[0].HeaderText = "Variable";


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
    }
}
