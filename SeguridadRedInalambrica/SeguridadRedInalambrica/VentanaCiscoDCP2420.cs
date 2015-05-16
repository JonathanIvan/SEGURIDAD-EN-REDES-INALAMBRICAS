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
    public partial class VentanaCiscoDCP2420 : Form
    {
        public VentanaCiscoDCP2420()
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

        private void VentanaCiscoDCP2420_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
