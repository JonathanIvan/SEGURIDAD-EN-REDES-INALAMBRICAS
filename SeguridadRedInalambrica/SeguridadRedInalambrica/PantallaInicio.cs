using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SeguridadRedInalambrica
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            
           
        InitializeComponent();
            
        }
        

     
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            switch (x)
            {

                case 0:
                    ponerMensaje("Buscando actualizaciones...");
                    break;
                case 20:
                    ponerMensaje("Conectando con la base de datos...");
                    break;
                case 40:
                    ponerMensaje("Conectado con librerias...");
                    break;
                case 50:
                    ponerMensaje("Cargando configuraciones...");
                    break;
                case 65:
                    ponerMensaje("Cargado los dispositivos...");
                    break;
                case 85:
                    ponerMensaje("Cargado los dispositivos...");
                    break;
                case 90:
                    ponerMensaje("Arrancando la aplicación...");
                    break;
                case 95:
                    ponerMensaje("Arrancando la aplicación...");
                    break;
            }
            x++;
            if (progressBar1.Value == 100) { 
                this.timer1.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            
       }
            public void ponerMensaje(string msg){
            lblcomponentes.Text=msg;
            }
        
    }
}
