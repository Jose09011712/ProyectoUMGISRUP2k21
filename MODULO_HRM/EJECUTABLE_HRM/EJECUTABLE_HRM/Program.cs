﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaHRM.MDI;
using CapaVistaHRM.Sergio.Mantenimientos;


namespace EJECUTABLE_HRM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CapaVistaHRM.Manuel.Mantenimientos.DatosPersonales());
        }
    }
}
