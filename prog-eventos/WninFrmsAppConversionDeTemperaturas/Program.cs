using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* Autor: Guillermo Alejandro Menjívar Artiga
* Carné: MA103625
* Descripción: Este programa convierte una escala de grados seleccionada a sus otras dos equivalentes según el enunciado del ejercicio
*/

namespace WninFrmsAppConversionDeTemperaturas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
