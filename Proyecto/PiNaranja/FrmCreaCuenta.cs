using System;
using PInaranja.Clases;
using System.Globalization;
using System.Threading;
using PiNaranja.Resources;
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
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNombreHogar.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCon.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos para continuar.");
            }
            else
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    if (Usuario.UsuarioYaRegistrado(txtNombre.Text) == false)
                    {
                        ConBD.CerrarConexion();
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
                    else
                    {
                        ConBD.CerrarConexion();
                        MessageBox.Show("El usuario ya está registrado. Inténtalo de nuevo");
                        txtNombre.Text = "";
                    }
                }
            }
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
            lblNombre.Text = Resources.Idioma.lblNombre;
            lblCorreo.Text = Resources.Idioma.lblCorreo;
            lblConstraseña.Text = Resources.Idioma.lblContraseña;
            btnCrearCuenta.Text = Resources.Idioma.btnCrearCuenta;
            grbRellena.Text = Resources.Idioma.grbRellena;
            lblIdioma.Text = Resources.Idioma.lblIdioma;
            lblCreaCuenta.Text = Resources.Idioma.lblCrearCuenta;
            this.Text = Resources.Idioma.FrmCrearCuenta;
            lblNombreHogar.Text = Resources.Idioma.lblNombreHogar;
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
