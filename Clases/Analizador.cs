using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaboratorioCompiladores.Clases
{
    internal class Analizador
    {
        private List<string> variables = new List<string>();
        private List<string> terminales = new List<string>();
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
                                    //terminal = terminal.Replace("'", "");
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
                lblTotalVariables.Text = $"Total: {variables.Count}";
                lblTotalTerminales.Text = $"Total: {terminales.Count}";
                lblTotalVariables.Visible = true;
                lblTotalTerminales.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarContenido(List<String> lista,TextBox tx)
        {
            if(lista.Count > 0)
            {
                foreach(String elemento in lista)
                {
                    tx.Text += $"{elemento}\r\n";
                }
            }
        }
    }
}