using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data;
using System.Linq;
using System.Drawing;

namespace LaboratorioCompiladores.Clases
{
    internal class Analizador
    {
        private List<string> variables = new List<string>();
        private List<string> terminales = new List<string>();
        private List<string[]> matrizProducciones = new List<string[]>();
        
        private void CargarContenido(List<String> lista, TextBox tx)
        {
            if (lista.Count > 0)
            {
                foreach (String elemento in lista)
                {
                    tx.Text += $"{elemento}\r\n";
                }
            }
        }

        private bool EncontrarProduccion(List<string[]> lista, string variable, string produccion)
        {
            foreach(string[] elemento in lista)
            {
                if (elemento[0] == variable && elemento[1]  == produccion)
                {
                    return true;
                }
            }
            return false;
        }

        public void DistribuirContenido(TextBox txtContenido, TextBox txtVariables, TextBox txtTerminales, Label lblTotalVariables, Label lblTotalTerminales)
        {
            try {
                Regex regex;
                MatchCollection coincidencias;
                string terminal;
                string er;
                string[] contenido;
                string[] producciones;
                bool epsilonEncontrado = false;
                
                foreach (string linea in txtContenido.Lines)
                {
                    if (linea.Length > 0)
                    {
                        contenido = linea.Split(new String[] { "=" }, StringSplitOptions.None);
                        if (contenido.Length == 2)
                        {
                            contenido[0] = contenido[0].Trim(' ');
                            if (!variables.Contains(contenido[0]))
                            {
                                variables.Add(contenido[0]);
                            }

                            //Revision de las producciones
                            contenido[1] = contenido[1].Trim(' ');
                            producciones = contenido[1].Split(new String[] { "|" }, StringSplitOptions.None);
                            er = @"\'(.*?)\'";
                            regex = new Regex(er);
                            foreach (string produccion in producciones)
                            {
                                if (produccion.Contains("e") && !epsilonEncontrado)
                                {
                                    epsilonEncontrado = true;
                                }

                                coincidencias = regex.Matches(produccion);
                                foreach (Match coincidencia in coincidencias)
                                {
                                    terminal = coincidencia.Value.Replace("'","");
                                    if (!terminales.Contains(terminal))
                                    {
                                        terminales.Add(terminal);
                                    }
                                }
                            }
                        }
                    }
                }
                if (epsilonEncontrado)
                {
                    terminales.Add("e");
                }
                CargarContenido(variables, txtVariables);
                CargarContenido(terminales, txtTerminales);
                lblTotalVariables.Text += $" [{variables.Count}]";
                lblTotalTerminales.Text += $" [{terminales.Count}]";
                lblTotalVariables.Visible = true;
                lblTotalTerminales.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarMatrizProducciones(TextBox txt, DataGridView dgv, Label lbl)
        {
            try
            {
                matrizProducciones.Add(new string[] { "Variable", "Producción" });
                foreach (string linea in txt.Lines)
                {
                    if (linea.Length > 0)
                    {
                        string[] subcadenas;
                        subcadenas = linea.Split(new String[] { "=" }, StringSplitOptions.None);
                        if (subcadenas.Length == 2)
                        {
                            string[] producciones;
                            subcadenas[0].Trim();
                            subcadenas[1].Trim();
                            producciones = subcadenas[1].Split(new String[] { "|" }, StringSplitOptions.None);

                            foreach (string produccion in producciones)
                            {
                                if (!EncontrarProduccion(matrizProducciones, subcadenas[0], produccion))
                                {
                                    matrizProducciones.Add(new string[] { subcadenas[0], produccion });
                                }
                            }
                        }
                    }
                }
                //Se adapta la matriz de producciones a un datatable para utilizar en la interfaz
                DataTable dt = new DataTable();
                foreach (string columna in matrizProducciones[0])
                {
                    dt.Columns.Add(columna);
                }

                for (int i = 1; i < matrizProducciones.Count; i++)
                {
                    dt.Rows.Add(matrizProducciones[i].ToArray());
                }

                dgv.DataSource = dt;

                //Configuracion visual de la tabla
                DataGridViewCellStyle style = new DataGridViewCellStyle();

                dgv.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

                for (int columna = 1; columna < dgv.ColumnCount; columna++)
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


                lbl.Text += $" [{dgv.RowCount}]";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}