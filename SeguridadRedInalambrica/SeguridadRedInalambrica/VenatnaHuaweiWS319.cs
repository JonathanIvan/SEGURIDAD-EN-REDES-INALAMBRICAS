using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguridadRedInalambrica
{
    public partial class VenatnaHuaweiWS319 : Form
    {
        public VenatnaHuaweiWS319()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaSeleccion seleccion = new VentanaSeleccion();
            seleccion.Show();
            this.SetVisibleCore(false);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

        }
       
        private void VenatnaHuaweiWS319_Load(object sender, EventArgs e)
        {

        }

        private void VentanaHuaweiWS319(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
