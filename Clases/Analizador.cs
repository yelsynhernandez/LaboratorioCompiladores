﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace LaboratorioCompiladores.Clases
{
    internal class Analizador
    {
        private List<string> variables = new List<string>();
        private List<string> terminales = new List<string>();
        public void DistribuirContenido(TextBox txtContenido, TextBox txtVariables, TextBox txtTerminales)
        {
            try { 

                string[] contenido;
                string[] producciones;
                string patron;
                bool epsilonEncontrado = false;
                foreach (string linea in txtContenido.Lines)
                {
                    if (linea.Length > 0)
                    {
                        contenido = linea.Split(new String[] { "=" }, StringSplitOptions.None);
                        //Verificando variable
                        contenido[0] = contenido[0].Trim(' ');
                        if (!variables.Contains(contenido[0]))
                        {
                            variables.Add(contenido[0]);
                        }

                        //Revision de las producciones
                        contenido[1] = contenido[1].Trim(' ');
                        producciones = contenido[1].Split(new String[] { "|" }, StringSplitOptions.None);
                        patron = @"\'(.*?)\'";
                        Regex regex = new Regex(patron);
                        foreach (string produccion in producciones)
                        {
                            if (produccion.Equals("e") && !epsilonEncontrado)
                            {
                                terminales.Add(produccion);
                                epsilonEncontrado = true;
                            }
                            else
                            {
                                MatchCollection coincidencias = regex.Matches(produccion);
                                foreach (Match coincidencia in coincidencias)
                                {
                                    string terminal = coincidencia.Value;
                                    terminal = terminal.Replace("'", "");
                                    if (!terminales.Contains(terminal))
                                    {
                                        terminales.Add(terminal);
                                    }
                                }
                            }
                        }
                    }
                }
                CargarContenido(variables, txtVariables);
                CargarContenido(terminales, txtTerminales); 
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