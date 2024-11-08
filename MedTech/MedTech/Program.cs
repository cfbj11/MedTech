using MedTech.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTech
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
            Application.Run(new InicioSesion());
            Application.Run(new MenuMed());
            Application.Run(new AggRegCita());
            Application.Run(new AggPaciente());
            Application.Run(new ExpedMed());
        }
    }
}
