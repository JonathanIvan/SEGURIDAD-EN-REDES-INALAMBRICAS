using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguridadRedInalambrica
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
            PantallaInicio pi = new PantallaInicio();
            if (pi.ShowDialog ()== DialogResult.OK)
            {
                Application.Run(new VentanaSeleccion());
            }
        }
    }
}
