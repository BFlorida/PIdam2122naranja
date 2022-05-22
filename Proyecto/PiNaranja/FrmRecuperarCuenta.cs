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
using PiNaranja.Resources;

namespace PiNaranja
{
    public partial class FrmRecuperarCuenta : Form
    {
        string correo;
        FrmInicioSesion inicio = new FrmInicioSesion();
        public FrmRecuperarCuenta()
        {
            InitializeComponent();
        }

        private void FrmRecuperarCuenta_Load(object sender, EventArgs e)
        {
            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
            txtUsuario.Enabled = true;
            txtCodigo.Enabled = false;
            txtContrasenya.Enabled = false;
        }


        /// <summary>
        /// Envia un mail con el codigo de verificacion al correo de la cuenta logeada. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe introducir un usuario para continuar.");
            }
            else
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    if (Usuario.UsuarioYaRegistrado(txtUsuario.Text))
                    {
                        ConBD.CerrarConexion();
                        Random random = new Random();
                        int verifyCode = random.Next(100000, 999999);
                        string mensaje = "Código de verificación para el cambio de la contraseña olvidada de la Cuenta de myHomy: \n\n" + verifyCode + "\n\n";
                        if (ConBD.Conexion != null)
                        {
                            ConBD.AbrirConexion();
                            Usuario.CambiaCodigo(txtUsuario.Text, verifyCode);
                            ConBD.CerrarConexion();
                        }
                        if (ConBD.Conexion != null)
                        {
                            ConBD.AbrirConexion();
                            correo = Usuario.GetCorreo(txtUsuario.Text);
                            ConBD.CerrarConexion();
                        }
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append(mensaje.Trim());
                        string para = correo;
                        string asunto = "Recuperacion de cuentas";
                        string error = "";
                        Correo.EnviarCorreo(stringBuilder, DateTime.Now, para.Trim(), asunto.Trim(), out error);
                        txtUsuario.Enabled = false;
                        txtCodigo.Enabled = true;
                        txtContrasenya.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no está registrado");
                        ConBD.CerrarConexion();
                    }
                }
            }
        }

        private void btnCambiarContrasenya_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtCodigo.Text;
            bool result = int.TryParse(s, out i);
            if (string.IsNullOrEmpty(txtContrasenya.Text) || string.IsNullOrEmpty(txtCodigo.Text) || result == false || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios y el código debe ser numérico.");
            }
            else
            {
                int codigo;
                int verifyCode = Convert.ToInt32(txtCodigo.Text);
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    codigo = Usuario.GetCodigo(txtUsuario.Text);
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
                        Usuario.CambiarContrasenya(txtUsuario.Text, txtContrasenya.Text);
                        ConBD.CerrarConexion();
                        inicio.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo incorrecto, revisa el correo y/o reenvialo de nuevo");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Hide();
        }

        private void AplicarIdioma()
        {
            this.Text = Resources.Idioma.frmRecuperarCuenta;
            lblCodigo.Text = Resources.Idioma.lblCodigo;
            lblUsuario.Text = Resources.Idioma.lblUsuario;
            lblNuevaCon.Text = Resources.Idioma.lblContrasenya;
            lblIdioma.Text = Resources.Idioma.lblIdioma;
            btnEnviarMail.Text = Resources.Idioma.btnEnviarMail;
            grbCambioCon.Text = Resources.Idioma.grbCambioCon;
            lblNuevaCon.Text = Resources.Idioma.lblNuevaCon;
            btnVolver.Text = Resources.Idioma.btnVolver;
            btnCambiarContrasenya.Text = Resources.Idioma.btnCambiarContraseña;
            grbRecuperacion.Text = Resources.Idioma.grbRecuperacion;
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
    }
}
