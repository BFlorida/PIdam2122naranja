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
<<<<<<< HEAD
        private string correo;
=======
<<<<<<< HEAD
        private string correo;
=======
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
        public FrmVerificacion(string usu)
        {
            InitializeComponent();
            usuario = usu;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                correo = Usuario.GetCorreo(usuario);
                ConBD.CerrarConexion();
            }
<<<<<<< HEAD
=======
=======
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
        }

        private void Verificacion_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Random random = new Random();
            int verifyCode = random.Next(100000, 999999);
=======
            MessageBox.Show(usuario);
            Random random = new Random();
            int verifyCode = random.Next(100000, 999999);
            MessageBox.Show(verifyCode.ToString());
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
            string mensaje = "Código de verificación para validación de la Cuenta de myHomy: \n\n" + verifyCode + "\n\n";
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Usuario.CambiaCodigo(usuario, verifyCode);
                ConBD.CerrarConexion();
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(mensaje.Trim());
<<<<<<< HEAD
            string para = correo; //obtencion de correo como sea
=======
<<<<<<< HEAD
            string para = correo; //obtencion de correo como sea
=======
            string para = "pabloski.2002@gmail.com"; //obtencion de correo como sea
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
            string asunto = "Validación del correo";
            string error = "";
            Correo.EnviarCorreo(stringBuilder, DateTime.Now, para.Trim(), asunto.Trim(), out error);
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmInicioSesion inicio = new FrmInicioSesion();
            inicio.Show();
            this.Hide();
        }
    }
}
