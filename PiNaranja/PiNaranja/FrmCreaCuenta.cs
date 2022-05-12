using System;
using PInaranja.Clases;
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

            Usuario user = new Usuario(txtNombre.Text,txtApellidos.Text,txtEmail.Text,txtCon.Text);
            Usuario.AgregarUsuario(user);
            
            frm.Show();
            this.Dispose();

        }



        private void ptbSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion frm = new FrmInicioSesion();

            frm.Show();
            this.Dispose();
        }
    }
}
