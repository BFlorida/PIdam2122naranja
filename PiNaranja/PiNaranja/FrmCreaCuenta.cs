using System;
using PInaranja.Clases;
using System.Globalization;
using System.Threading;
using PiNaranja.Recursos;
using System.Windows.Forms;


namespace PiNaranja
{
    public partial class FrmCreaCuenta : Form
    {
        public FrmCreaCuenta()
        {
            InitializeComponent();
        }
   
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmInicioSesion frm = new FrmInicioSesion();
            Usuario user = new Usuario(txtNombre.Text, txtEmail.Text, txtCon.Text);
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Usuario.AgregarUsuario(user);

                Casa home = new Casa(txtNombreHogar.Text, txtNombre.Text);
                Casa.AgregaCasa(home);
                ConBD.CerrarConexion();
            }
            frm.Show();
            this.Dispose();

        }



        private void ptbSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion frm = new FrmInicioSesion();

            frm.Show();
            this.Dispose();
        }

        private void FrmCreaCuenta_Load(object sender, EventArgs e)
        {
            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblNombre.Text = Recursos.Idioma.lblNombre;
            lblCorreo.Text = Recursos.Idioma.lblCorreo;
            lblConstraseña.Text = Recursos.Idioma.lblContraseña;
            btnCrearCuenta.Text = Recursos.Idioma.btnCrearCuenta;
            grbRellena.Text = Recursos.Idioma.grbRellena;
            lblIdioma.Text = Recursos.Idioma.lblIdioma;
            lblCreaCuenta.Text = Recursos.Idioma.lblCrearCuenta;
            this.Text = Recursos.Idioma.FrmCrearCuenta;
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
