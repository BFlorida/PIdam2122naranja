using System;
using PiNaranja.Clases;
using PInaranja.Clases;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PiNaranja
{
    public partial class FrmVerificacion : Form
    {
        private string usuario;
        private string correo;
        public FrmVerificacion(string usu)
        {
            InitializeComponent();
            usuario = usu;
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                correo = Usuario.GetCorreo(usuario);
                ConBD.CerrarConexion();
            }
        }

        /// <summary>
        /// Envia un mail con el codigo de verificacion al correo de la cuenta logeada. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Verificacion_Load(object sender, EventArgs e)
        {
            //Número aleatorio entre 100000 y 999999 que servira de codigo de verificacion. 
            Random random = new Random();
            int verifyCode = random.Next(100000, 999999);
            //Cuerpo del mail con el codigo de verificacion. 
            string mensaje = "Código de verificación para validación de la Cuenta de myHomy: \n\n" + verifyCode + "\n\n";
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                //Asigna el codigo de verificacion previamente creado a la cuenta que intenta iniciar sesion por primera vez. 
                Usuario.CambiaCodigo(usuario, verifyCode);
                ConBD.CerrarConexion();
            }
            //Construimos un stringbuilder de mensaje con el cuerpo del mensaje, asunto
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(mensaje.Trim());
            string para = correo; //obtencion de correo como sea
            string asunto = "Validación del correo";
            string error = "";
            //Enviamos el mensaje con el cuerpo, la fecha de hoy, el usuario a quien se envia y el asunto. 
            Correo.EnviarCorreo(stringBuilder, DateTime.Now, para.Trim(), asunto.Trim(), out error);
            MessageBox.Show("Revise su correo, recibirá un código de verificación");

            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
        }

        private void btnCheckVCode_Click(object sender, EventArgs e)
        {
            FrmPanelControl panel = new FrmPanelControl(usuario);
            int codigo;
            int verifyCode = Convert.ToInt32(txtCode.Text);
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                codigo = Usuario.GetCodigo(usuario);
                ConBD.CerrarConexion();
            }
            else
            {
                codigo = 9999999;
            }
            if (verifyCode == codigo)
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    Usuario.ActivarVerificacion(usuario);
                    ConBD.CerrarConexion();
                    panel.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Codigo incorrecto, revisa el correo y/o reenvialo de nuevo");
            }
        }
        private void AplicarIdioma()
        {
            this.Text =
            lblIdioma.Text = Resources.Idioma.lblIdioma;
            lblCode.Text = Resources.Idioma.lblCode;
            btnCheckVCode.Text = Resources.Idioma.btnCheckVCode;
            btnReturn.Text = Resources.Idioma.btnReturn;
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (cmbIdioma.Text)
            {
                case "Castellano":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "English":
                    {
                        cultura = "EN-GB";
                        break;
                    }
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmInicioSesion inicio = new FrmInicioSesion();
            inicio.Show();
            this.Hide();
        }

        //Comprueba si el código que hemos recibio se corresponde con el introducido en el campo. 
        private void btnCheckVCode_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtCode.Text;
            bool result = int.TryParse(s, out i);
            if (string.IsNullOrEmpty(txtCode.Text) || result == false)
            {
                MessageBox.Show("El código es erroneo.");
            }
            else
            {
                FrmPanelControl panel = new FrmPanelControl(usuario);
                int codigo;
                int verifyCode = Convert.ToInt32(txtCode.Text);
                if (ConBD.Conexion != null)
                {
                    //Saca el codigo que el usuari ha recibio y lo coteja para comprobar si es el correcto. 
                    ConBD.AbrirConexion();
                    codigo = Usuario.GetCodigo(usuario);
                    ConBD.CerrarConexion();
                }
                else
                {
                    //si no es el correcto se le asigna un codigo fijo. 
                    codigo = 9999999;
                }
                if (verifyCode == codigo)
                {
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();
                        //verifica al usuario. 
                        Usuario.ActivarVerificacion(usuario);
                        ConBD.CerrarConexion();
                        panel.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo incorrecto, revisa el correo y/o reenvialo de nuevo");
                }
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmInicioSesion fmis = new FrmInicioSesion();
            fmis.Show();
        }
    }
}
