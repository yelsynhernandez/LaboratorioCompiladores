using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Runtime.Serialization.Formatters;

namespace LaboratorioCompiladores.Clases
{
    internal class Analizador
    {
        private List<string> variables = new List<string>();
        private List<string> terminales = new List<string>();
        private List<string[]> matrizProducciones = new List<string[]>();
        
        private void CargarContenido(List<String> lista, DataGridView dgv)
        {
            if (lista.Count > 0)
            {
                foreach (String elemento in lista)
                {
                    dgv.Rows.Add(elemento);
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

        public void DistribuirContenido(TextBox txtContenido, DataGridView dgvVariables, DataGridView dgvTerminales)
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
                CargarContenido(variables, dgvVariables);
                CargarContenido(terminales, dgvTerminales);
                dgvVariables.Columns[0].HeaderText = $"Variables [{variables.Count}]";
                dgvTerminales.Columns[0].HeaderText = $"Terminales [{terminales.Count}]";
                dgvVariables.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                dgvVariables.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvTerminales.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.DisplayedCells);
                dgvTerminales.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarMatrizProducciones(TextBox txt, DataGridView dgv)
        {
            try
            {
                matrizProducciones.Clear();
                foreach(string linea in txt.Lines)
                {
                    if (linea.Length > 0)
                    {
                        string[] subcadena;
                        subcadena = linea.Split(new String[] { "=" }, StringSplitOptions.None);
                        if (subcadena.Length == 2)
                        {
                            string[] producciones;
                            subcadena[0].Trim();
                            subcadena[1].Trim();
                            producciones = subcadena[1].Split(new String[] { "|" }, StringSplitOptions.None);

                            foreach (string produccion in producciones)
                            {
                                if(!EncontrarProduccion(matrizProducciones, subcadena[0], produccion))
                                {
                                    matrizProducciones.Add(new string[] { subcadena[0], produccion});
                                }
                            }
                        }
                    }
                }

                DataTable dt = new DataTable();
                int columnas = 1;
                int maximoColumnas = 0;
                int actual = 0;
                dt.Columns.Add(String.Empty);
                for (int i = 0; i < matrizProducciones.Count; i++)
                {
                    DataRow fila = dt.NewRow();
                    if (matrizProducciones[i].Length == 2)
                    {
                        string[] posicion = matrizProducciones[i][1].Split(' ');
                        actual = posicion.Length + 1;
                        if(actual > maximoColumnas)
                        {
                            maximoColumnas = actual;
                            while (columnas < maximoColumnas)
                            {
                                dt.Columns.Add(String.Empty);
                                columnas++;
                            }
                        }
                        int posicionFila = 0;
                        fila[posicionFila] = matrizProducciones[i][0];
                        posicionFila++;
                        for(int val = 0; val < posicion.Length; val++)
                        {
                            string dato = posicion[val].Replace("'", string.Empty);
                            if (dato.Length > 0)
                            {
                                dato = dato.Trim();
                                fila[posicionFila] = dato;
                                posicionFila++;
                            }
                        }
                    }
                    else
                    {
                        fila[0] = matrizProducciones[i][0];
                    }
                    dt.Rows.Add(fila);
                }

                dgv.DataSource = dt;
                foreach(DataGridViewColumn columna in dgv.Columns)
                {
                    columna.HeaderText = String.Empty;
                }
                dgv.Columns[0].HeaderText = "Variable";


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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public void RemoverRecursividad(TextBox entrada, TextBox salida)
        {
            string[] lineas= entrada.Text.Split('\n');
            foreach (string linea in lineas)
            {
                linea.TrimEnd('\r');
                linea.Trim();
                if(linea.Length > 0)
                {
                    string[] partes = linea.Split(new string[] { "=" }, StringSplitOptions.None);
                    string izquierda = partes[0].Trim();
                    string[] partesDerecha = partes[1].Split('|');
                    List<string> noRecursiva = new List<string>();
                    List<string> recursiva = new List<string>();
                    foreach (string derecha in partesDerecha)
                    {
                        if (derecha.Trim().StartsWith(izquierda))
                        {
                            recursiva.Add(derecha.Trim().Substring(izquierda.Length));
                        }
                        else
                        {
                            noRecursiva.Add(derecha.Trim());
                        }
                    }
                    if (recursiva.Count > 0)
                    {
                        if (noRecursiva.Count > 0)
                        {
                            salida.AppendText($"{izquierda}=");
                            for (int i = 0; i < noRecursiva.Count; i++)
                            {
                                salida.AppendText($"{noRecursiva[i]} {izquierda}1");
                                if (i < noRecursiva.Count - 1)
                                {
                                    salida.AppendText("|");
                                }
                            }
                            salida.AppendText("\r\n");
                        }
                        salida.AppendText($"{izquierda}1=");
                        for (int i = 0; i < recursiva.Count; i++)
                        {
                            salida.AppendText($"{recursiva[i].Trim()} {izquierda}1|e");
                            if (i < recursiva.Count - 1)
                            {
                                salida.AppendText("|");
                            }
                        }
                        salida.AppendText("\r\n");
                    }
                    else
                    {
                        salida.AppendText(linea + "\r\n");
                    }
                }
            }
        }
        private bool Buscar(DataGridView dgv, string valorBuscado)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells[1].Value != null && 
                    fila.Cells[1].Value.ToString().Trim() == valorBuscado.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        public void FuncionPrimero(DataGridView gramatica, DataGridView terminales, DataGridView producciones)
        {
            List<string> resultado = new List<string>();
            for(int i = 0; i < gramatica.Rows.Count; i++)
            {
                string primerPosicion = gramatica.Rows[i].Cells[1].Value?.ToString();
                //Es terminal?
                if(Buscar(terminales, primerPosicion))
                {
                    resultado.Add(primerPosicion);
                }

                if(Buscar(producciones, primerPosicion))
                {
                    resultado.Add("");
                }
            }
        }

    }
}