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

        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
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
            string para = correo; //obtencion de correo como sea
            string asunto = "Recuperacion de cuentas";
            string error = "";
            Correo.EnviarCorreo(stringBuilder, DateTime.Now, para.Trim(), asunto.Trim(), out error);
        }

        private void btnCambiarContrasenya_Click(object sender, EventArgs e)
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
                    Usuario.CambiarContrasenya(txtUsuario.Text,txtContrasenya.Text);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Hide();
        }


    }
}
