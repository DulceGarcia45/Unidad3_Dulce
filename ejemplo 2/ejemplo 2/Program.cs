﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejemplo_2;
using ejemplo_2.Campeonato.Vista;
using ejemplo_2.Actividades_3_4_5.Vista;

namespace ejemplo_2
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
            Application.Run(new Inicio_Campeonato());
        }
    }
}
