using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            CookieContainer Login = new CookieContainer();
            //ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            HttpWebRequest peticion = (HttpWebRequest)WebRequest.Create("http://192.168.3.1/html/index.html");
            peticion.Method = "GET";
            peticion.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            peticion.KeepAlive = true;
            peticion.CookieContainer = Login;
            peticion.Host = "192.168.3.1";
            peticion.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/36.0.1985.143 Safari/537.36";


            HttpWebResponse respuestainicio = (HttpWebResponse)peticion.GetResponse();
            StreamReader lectorinicio = new StreamReader(respuestainicio.GetResponseStream());
            string html3 = lectorinicio.ReadToEnd();

            string[] fuentes = html3.Split(new string[] { "<meta name=\"csrf_param\" content=\"", "\"/>" }, StringSplitOptions.None);

            string param = fuentes[1].Trim();



            string[] fuentes2 = html3.Split(new string[] { "<meta name=\"csrf_token\" content=\"", "\"/>" }, StringSplitOptions.None);

            string token = fuentes2[2].Trim();



            CookieContainer Login2 = new CookieContainer();
            string json = "{\"csrf\":{\"csrf_param\":\"" + param + "\",\"csrf_token\":\"" + token + "\"},\"data\":{\"UserName\":\"admin\",\"Password\":\"OGM2OTc2ZTViNTQxMDQxNWJkZTkwOGJkNGRlZTE1ZGZiMTY3YTljODczZmM0YmI4YTgxZjZmMmFiNDQ4YTkxOA==\"}}";

            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            HttpWebRequest peticionLogin = (HttpWebRequest)WebRequest.Create("http://192.168.3.1/api/system/user_login");
            peticionLogin.ProtocolVersion = HttpVersion.Version11;
            peticionLogin.Method = "POST";
            peticionLogin.Accept = "application/json, text/javascript, */*; q=0.01";
            peticionLogin.Headers.Add("X-Requested-With", "XMLHttpRequest");
            peticionLogin.AllowAutoRedirect = true;
            peticionLogin.CookieContainer = Login;
            peticionLogin.ContentLength = 234;
            peticionLogin.ContentType = " application/json;charset=UTF-8";
            peticionLogin.Host = "192.168.3.1";
            peticionLogin.Referer = "http://192.168.3.1/html/index.html";
            peticionLogin.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";

            StreamWriter sw = new StreamWriter(peticionLogin.GetRequestStream());

            sw.Write(json);
            sw.Flush();
            sw.Close();

            HttpWebResponse respuestaLogin = (HttpWebResponse)peticionLogin.GetResponse();
            StreamReader lectorLogin = new StreamReader(respuestaLogin.GetResponseStream());
            string html = lectorLogin.ReadToEnd();




            HttpWebRequest peticionWizard = (HttpWebRequest)WebRequest.Create("http://192.168.3.1/html/wizard/wizard.html");

            peticionWizard.Method = "GET";
            peticionWizard.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            peticionWizard.KeepAlive = true;
            peticionWizard.CookieContainer = Login;
            peticionWizard.Host = "192.168.3.1";
            peticionWizard.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
            HttpWebResponse respuestaWinzard = (HttpWebResponse)peticionWizard.GetResponse();
            StreamReader lectorWinzard = new StreamReader(respuestaWinzard.GetResponseStream());
            string html1 = lectorWinzard.ReadToEnd();

            HttpWebRequest peticionAdvanceLan = (HttpWebRequest)WebRequest.Create("http://192.168.3.1/html/advance.html#landevices");

            peticionAdvanceLan.Method = "GET";
            peticionAdvanceLan.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            peticionAdvanceLan.KeepAlive = true;
            peticionAdvanceLan.CookieContainer = Login;
            peticionAdvanceLan.Host = "192.168.3.1";
            peticionAdvanceLan.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
            HttpWebResponse respuestaAdvanceLan = (HttpWebResponse)peticionAdvanceLan.GetResponse();
            StreamReader lectorAdvanceLan = new StreamReader(respuestaAdvanceLan.GetResponseStream());
            string htmlAdvance = lectorAdvanceLan.ReadToEnd();
            string[] fuentesAdvance = htmlAdvance.Split(new string[] { "<meta name=\"csrf_param\" content=\"", "\"/>" }, StringSplitOptions.None);

            string paramAdvance = fuentesAdvance[1].Trim();



            string[] fuentesAdvance2 = htmlAdvance.Split(new string[] { "<meta name=\"csrf_token\" content=\"", "\"/>" }, StringSplitOptions.None);

            string tokeAdvance = fuentesAdvance2[2].Trim();


            HttpWebRequest peticionWifisync = (HttpWebRequest)WebRequest.Create("http://192.168.3.1/api/ntwk/wlanwifisync");

            peticionWifisync.Method = "GET";
            peticionWifisync.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            peticionWifisync.KeepAlive = true;
            peticionWifisync.CookieContainer = Login;
            peticionWifisync.Host = "192.168.3.1";
            peticionWifisync.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
            HttpWebResponse respuestaWifisync = (HttpWebResponse)peticionWifisync.GetResponse();
            StreamReader lectorWifisync = new StreamReader(respuestaWifisync.GetResponseStream());
            string htmlWifisync = lectorWifisync.ReadToEnd();

            string json5 = "{\"csrf\":{\"csrf_param\":\"" + paramAdvance + "\",\"csrf_token\":\"" + tokeAdvance + "\"},\"action\":\"AllSsidSettings\",\"data\":[{\"ID\":\"InternetGatewayDevice.LANDevice.1.WLANConfiguration.1.\",\"ssid\":\"" + txtNombreRed.Text + "\",\"ssidenable\":true,\"isolate\":false,\"advertisement\":1,\"beacontype\":\"WPAand11i\",\"wpaencmode\":\"TKIP+AES\",\"wpakey\":\"" + txtContraRed.Text + "\"}]}";
            byte[] byteArray2 = Encoding.UTF8.GetBytes(json5);
            
            HttpWebRequest peticionWlan = (HttpWebRequest)WebRequest.Create("http://192.168.3.1/api/ntwk/WlanBasic");

            peticionWlan.Accept = "application/json, text/javascript, */*; q=0.01";
            peticionWlan.ContentLength = byteArray2.Length;
            peticionWlan.Method = "POST";
            peticionWlan.Headers.Add("X-Requested-With", "XMLHttpRequest");

            peticionWlan.ContentType = " application/json;charset=UTF-8";
            peticionWlan.KeepAlive = true;
            peticionWlan.CookieContainer = Login;
            peticionWlan.Host = "192.168.3.1";
            peticionWlan.Referer = "http://192.168.3.1/html/advance.html";
            peticionWlan.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/36.0.1985.143 Safari/537.36";
            StreamWriter sw2 = new StreamWriter(peticionWlan.GetRequestStream());

            sw2.Write(json5, 0, byteArray2.Length);
            sw2.Flush();
            sw2.Close();
          
            HttpWebResponse respuestaWlan = (HttpWebResponse)peticionWlan.GetResponse();
            StreamReader lectorWlan = new StreamReader(respuestaWlan.GetResponseStream());

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
