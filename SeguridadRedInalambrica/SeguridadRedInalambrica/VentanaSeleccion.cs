using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SeguridadRedInalambrica
{
    public partial class VentanaSeleccion : Form
    {
        public string valorventana;

        public VentanaSeleccion()
        {
           
            InitializeComponent();
          
        }
       
        
        private void txtSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arris="ARRIS TG862A";
            string cisco="CISCO DPC2420";
            string huawei="HUAWEI WS319";

             if(txtSeleccion.Text==arris){

               ImagenSeleccion.Image = Image.FromFile("tg862.jpg");
               valorventana = "arris";
             }else if(txtSeleccion.Text==cisco){

                 ImagenSeleccion.Image = Image.FromFile("dcp2420.jpg");
                 valorventana = "cisco";
             }
             else if (txtSeleccion.Text == huawei)
             {

                 ImagenSeleccion.Image = Image.FromFile("ws319.jpg");
                 valorventana = "huawei";
             }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(valorventana=="arris"){
                VentanaArrisTG862A ventanaaris = new VentanaArrisTG862A();
                ventanaaris.Show();
                this.SetVisibleCore(false);
            }
            else if (valorventana == "cisco")
            {
                VentanaCiscoDCP2420 venatanacisco = new VentanaCiscoDCP2420();
                venatanacisco.Show();
                this.SetVisibleCore(false);
            }
            else if (valorventana == "huawei")
            {
                VenatnaHuaweiWS319 ventanahuawei = new VenatnaHuaweiWS319();
                ventanahuawei.Show();
                this.SetVisibleCore(false);
            } 
        }

        private void VentanaSeleccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

                }
}
