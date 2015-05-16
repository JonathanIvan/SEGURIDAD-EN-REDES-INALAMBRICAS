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
    public partial class VentanaArrisTG862A : Form
    {
        public VentanaArrisTG862A()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaSeleccion seleccion = new VentanaSeleccion();
            seleccion.Show();
            this.SetVisibleCore(false);
        }

        private void VentanaArrisTG862A_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
