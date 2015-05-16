using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace SeguridadRedInalambrica
{
    public partial class VentanaCiscoDCP2420 : Form
    {
        public VentanaCiscoDCP2420()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaSeleccion seleccion = new VentanaSeleccion();
            seleccion.Show();
            this.SetVisibleCore(false);
        }

        public void Desencriptar() {
            CookieContainer login2 = new CookieContainer();
            string postData = "username_login=cisco&password_login=cisco&LanguageSelect=en&Language_Submit=0&login=Log+In";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);


            HttpWebRequest peticionlogin = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/goform/Docsis_system");
            peticionlogin.ProtocolVersion = HttpVersion.Version11;
            peticionlogin.Method = "POST";
            peticionlogin.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticionlogin.ContentLength = 90;
            peticionlogin.ContentType = "application/x-www-form-urlencoded";
            peticionlogin.CookieContainer = login2;
            peticionlogin.Host = "192.168.0.1";
            peticionlogin.Referer = "192.168.0.1/Docsis_system.asp";
            peticionlogin.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";



            StreamWriter sw = new StreamWriter(peticionlogin.GetRequestStream());
            sw.Write(postData, 0, byteArray.Length);
            sw.Close();

            HttpWebResponse respuestaLogin = (HttpWebResponse)peticionlogin.GetResponse();
            StreamReader lectorLogin = new StreamReader(respuestaLogin.GetResponseStream());
            string html = lectorLogin.ReadToEnd();

            HttpWebRequest peticion = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/Quick_setup.asp");
            peticion.Method = "GET";
            peticion.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticion.KeepAlive = true;
            peticion.CookieContainer = login2;
            peticion.Host = "192.168.0.1";
            peticion.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/36.0.1985.143 Safari/537.36";


            HttpWebResponse respuesta = (HttpWebResponse)peticion.GetResponse();
            StreamReader lector = new StreamReader(respuesta.GetResponseStream());
            string html1 = lector.ReadToEnd();

            string postData2 = "Password=&PasswordReEnter=&setup_wifi_enable=enable&security_mode=psk2_mixed&radius_ip_1=0&" +
            "radius_ip_2=0&radius_ip_3=0&radius_ip_4=0&keysize=64&tx_key=" +
            "1&wl5g_setup_wifi_enable=enable&qs_h_network_band_5G=2&wl5g_ssid=" + txtNombreRed.Text
            + "&wl5g_security_mode=psk2&wl5g_wpa_enc=aes&wl5g_wpa_psk_key=" + txtContraRed.Text
            + "g_UnhiddenPresharedKey=0x01&wl5g_radius_ip_1=0&wl5g_radius_ip_2"
            + "=0&wl5g_radius_ip_3=0&wl5g_radius_ip_4=0&wl5g_keysize=64&wl5g_tx_key="
            + "1&save=Save+Settings&h_wl5g_setup_wifi_enable=enable&h_wl5g_security_mode=psk2&h_wl5g_wpa_enc" +
            "=aes&qs_wds_setting=disable&wl5g_qs_wds_setting=disable&UserId=";
            byte[] byteArray2 = Encoding.UTF8.GetBytes(postData2);


            HttpWebRequest peticionLoginRed = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/goform/Quick_setup");
            peticionLoginRed.ProtocolVersion = HttpVersion.Version11;
            peticionLoginRed.Method = "POST";
            peticionLoginRed.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticionLoginRed.ContentLength = byteArray2.Length;
            peticionLoginRed.ContentType = "application/x-www-form-urlencoded";
            peticionLoginRed.CookieContainer = login2;
            peticionLoginRed.Host = "192.168.0.1";
            peticionLoginRed.Referer = "192.168.0.1/Quick_setup.asp";
            peticionLoginRed.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";



            StreamWriter Escrtitura = new StreamWriter(peticionLoginRed.GetRequestStream());
            Escrtitura.Write(postData2, 0, byteArray2.Length);
            Escrtitura.Close();

            HttpWebResponse respuestaLoginRed = (HttpWebResponse)peticionlogin.GetResponse();
            StreamReader lectorLoginRed = new StreamReader(respuestaLoginRed.GetResponseStream());
            string html3 = lectorLogin.ReadToEnd();
        
        
        }

        public void MostrarDatos()
        {
            CookieContainer login = new CookieContainer();
            string postData = "username_login=cisco&password_login=cisco&LanguageSelect=en&Language_Submit=0&login=Log+In";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);


            HttpWebRequest peticionlogin = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/goform/Docsis_system");
            peticionlogin.ProtocolVersion = HttpVersion.Version11;
            peticionlogin.Method = "POST";
            peticionlogin.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticionlogin.ContentLength = 90;
            peticionlogin.ContentType = "application/x-www-form-urlencoded";
            peticionlogin.CookieContainer = login;
            peticionlogin.Host = "192.168.0.1";
            peticionlogin.Referer = "192.168.0.1/Docsis_system.asp";
            peticionlogin.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";



            StreamWriter sw = new StreamWriter(peticionlogin.GetRequestStream());
            sw.Write(postData, 0, byteArray.Length);
            sw.Close();

            HttpWebResponse respuestaLogin = (HttpWebResponse)peticionlogin.GetResponse();
            StreamReader lectorLogin = new StreamReader(respuestaLogin.GetResponseStream());
            string html = lectorLogin.ReadToEnd();


            HttpWebRequest peticion = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/Quick_setup.asp");
            peticion.Method = "GET";
            peticion.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticion.KeepAlive = true;
            peticion.CookieContainer = login;
            peticion.Host = "192.168.0.1";
            peticion.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/36.0.1985.143 Safari/537.36";


            HttpWebResponse respuesta = (HttpWebResponse)peticion.GetResponse();
            StreamReader lector = new StreamReader(respuesta.GetResponseStream());
            string html1 = lector.ReadToEnd();

            string[] fuentes1 = html1.Split(new string[] { "<input type=\"text\" maxlength=\"32\" name=\"wl5g_ssid\" id=\"wl5g_ssid\" value=\"", "\" />" }, StringSplitOptions.None);


            string SSDI = fuentes1[21].Trim();

            txtNombreRed.Text = "" + SSDI;
            string[] fuentes2 = html1.Split(new string[] { "<input type=\"text\" class=\"num\" id=\"wl5g_wpa_psk_key\" name=\"wl5g_wpa_psk_key\" size=\"32\" maxlength=\"64\" value=\"", "\" onKeyDown=\"keyCheck(this)\"  onSelect=\"textSelected=true\" />" }, StringSplitOptions.None);


            string Password = fuentes2[2].Trim();
            txtContraRed.Text = "" + Password;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            CookieContainer login2 = new CookieContainer();
            string postData = "username_login=cisco&password_login=cisco&LanguageSelect=en&Language_Submit=0&login=Log+In";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);


            HttpWebRequest peticionlogin = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/goform/Docsis_system");
            peticionlogin.ProtocolVersion = HttpVersion.Version11;
            peticionlogin.Method = "POST";
            peticionlogin.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticionlogin.ContentLength = 90;
            peticionlogin.ContentType = "application/x-www-form-urlencoded";
            peticionlogin.CookieContainer = login2;
            peticionlogin.Host = "192.168.0.1";
            peticionlogin.Referer = "192.168.0.1/Docsis_system.asp";
            peticionlogin.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";



            StreamWriter sw = new StreamWriter(peticionlogin.GetRequestStream());
            sw.Write(postData, 0, byteArray.Length);
            sw.Close();

            HttpWebResponse respuestaLogin = (HttpWebResponse)peticionlogin.GetResponse();
            StreamReader lectorLogin = new StreamReader(respuestaLogin.GetResponseStream());
            string html = lectorLogin.ReadToEnd();

            HttpWebRequest peticion = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/Quick_setup.asp");
            peticion.Method = "GET";
            peticion.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticion.KeepAlive = true;
            peticion.CookieContainer = login2;
            peticion.Host = "192.168.0.1";
            peticion.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/36.0.1985.143 Safari/537.36";


            HttpWebResponse respuesta = (HttpWebResponse)peticion.GetResponse();
            StreamReader lector = new StreamReader(respuesta.GetResponseStream());
            string html1 = lector.ReadToEnd();

            string postData2 = "Password=&PasswordReEnter=&setup_wifi_enable=enable&security_mode=psk2_mixed&radius_ip_1=0&" +
            "radius_ip_2=0&radius_ip_3=0&radius_ip_4=0&keysize=64&tx_key=" +
            "1&wl5g_setup_wifi_enable=enable&qs_h_network_band_5G=2&wl5g_ssid=" + txtNombreRed.Text
            + "&wl5g_security_mode=psk2&wl5g_wpa_enc=aes&wl5g_wpa_psk_key=" + txtContraRed.Text
            + "g_UnhiddenPresharedKey=0x01&wl5g_radius_ip_1=0&wl5g_radius_ip_2"
            + "=0&wl5g_radius_ip_3=0&wl5g_radius_ip_4=0&wl5g_keysize=64&wl5g_tx_key="
            + "1&save=Save+Settings&h_wl5g_setup_wifi_enable=enable&h_wl5g_security_mode=psk2&h_wl5g_wpa_enc" +
            "=aes&qs_wds_setting=disable&wl5g_qs_wds_setting=disable&UserId=";
            byte[] byteArray2 = Encoding.UTF8.GetBytes(postData2);


            HttpWebRequest peticionLoginRed = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/goform/Quick_setup");
            peticionLoginRed.ProtocolVersion = HttpVersion.Version11;
            peticionLoginRed.Method = "POST";
            peticionLoginRed.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            peticionLoginRed.ContentLength = byteArray2.Length;
            peticionLoginRed.ContentType = "application/x-www-form-urlencoded";
            peticionLoginRed.CookieContainer = login2;
            peticionLoginRed.Host = "192.168.0.1";
            peticionLoginRed.Referer = "192.168.0.1/Quick_setup.asp";
            peticionLoginRed.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";



            StreamWriter Escrtitura = new StreamWriter(peticionLoginRed.GetRequestStream());
            Escrtitura.Write(postData2, 0, byteArray2.Length);
            Escrtitura.Close();

            HttpWebResponse respuestaLoginRed = (HttpWebResponse)peticionlogin.GetResponse();
            StreamReader lectorLoginRed = new StreamReader(respuestaLoginRed.GetResponseStream());
            string html3 = lectorLogin.ReadToEnd();
        }

        private void VentanaCiscoDCP2420_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
