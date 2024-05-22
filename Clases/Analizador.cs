using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;

namespace LaboratorioCompiladores.Clases
{
    internal class Analizador
    {
        private List<string> variables = new List<string>();
        private List<string> terminales = new List<string>();
        private List<string[]> matrizProducciones = new List<string[]>();
        Ajuste ajuste = new Ajuste();
        
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
                ajuste.FormatoDataGrid(dgv);
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

        public string AjustarGramatica(string contenido)
        {
            string[] lineas = contenido.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> producciones = new Dictionary<string, List<string>>();

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('=');
                string variable = partes[0].Trim();
                string produccion = partes[1].Trim();

                if (!producciones.ContainsKey(variable))
                {
                    producciones[variable] = new List<string>();
                }
                producciones[variable].Add(produccion);
            }

            // Ordenar las variables según el orden específico deseado
            var ordenVariables = new List<string> { "S", "S1", "T", "T1", "F" };
            var variablesOrdenadas = producciones.Keys
                .OrderBy(v => ordenVariables.IndexOf(v))
                .ToList();

            StringBuilder resultado = new StringBuilder();

            foreach (string variable in variablesOrdenadas)
            {
                List<string> listaProducciones = producciones[variable];

                // Agrupar producciones y eliminar duplicados
                var produccionesAgrupadas = listaProducciones
                    .SelectMany(p => p.Split('|'))
                    .Distinct()
                    .OrderBy(p => p == "e" ? 1 : 0)
                    .ThenBy(p => p)
                    .ToList();

                resultado.AppendLine($"{variable}={string.Join("|", produccionesAgrupadas)}");
            }

            return resultado.ToString();
        }

        private bool Buscar(DataGridView dgv, string valorBuscado)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells[0].Value != null && 
                    fila.Cells[0].Value.ToString().Trim() == valorBuscado)
                {
                    return true;
                }
            }
            return false;
        }

        public void FuncionPrimero(DataGridView gramatica, DataGridView terminales, DataGridView producciones, DataGridView produccionesFuncionPrimero)
        {
            List<string> filas = new List<string>();
            string stringFila;

            string primerPosicion;
            string variable;
            string variableAnterior = null;
            for (int i = 0;i < gramatica.Rows.Count; i++)
            {
                variable = gramatica.Rows[i].Cells[0].Value.ToString().Trim();
                //Asignamos la primer columna a la variable
                stringFila = $"{variable},";


                primerPosicion = gramatica.Rows[i].Cells[1].Value.ToString().Trim();
                //es terminal?
                if(Buscar(terminales, primerPosicion))
                {
                    stringFila += $"{primerPosicion},";
                }

                if (variableAnterior != null && (variable == variableAnterior))
                {
                    Console.WriteLine($"Analizando la misma variable [{variable}]/[{variableAnterior}]");
                }

                /*string primerPosicion = gramatica.Rows[i].Cells[1].Value?.ToString();
                
                if(Buscar(terminales, primerPosicion))
                {
                    resultado.Add(primerPosicion);
                }

                if(Buscar(producciones, primerPosicion))
                {
                    resultado.Add("");
                }*/
                variableAnterior = variable;
                //Agregamos a la lista de producciones, removiendo la última coma
                filas.Add(stringFila.Remove(stringFila.Length - 1));
            }

            //Despues de generarse las producciones de la funcion "primero", dimensionamos la informacion para cargarla
            DataTable dt = new DataTable();
            int columnas = 0;
            int maximoColumnas;
            for(int i = 0; i < filas.Count; i++)
            {
                string[] elemento = filas[i].Split(',');
                if(elemento.Length > columnas)
                {
                    maximoColumnas = elemento.Length;
                    while(columnas < maximoColumnas)
                    {
                        dt.Columns.Add(String.Empty);
                        columnas++;
                    }
                }
                DataRow dr = dt.NewRow();
                for(int columna = 0; columna < elemento.Length; columna++)
                {
                    dr[columna] = elemento[columna];
                }
                dt.Rows.Add(dr);
            }

            produccionesFuncionPrimero.DataSource = dt;
            ajuste.FormatoDataGrid(produccionesFuncionPrimero);
        }

    }
}