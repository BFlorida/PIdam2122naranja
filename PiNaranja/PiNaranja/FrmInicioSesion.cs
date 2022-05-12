using System;
using PInaranja.Clases;
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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            FrmPanelControl frm = new FrmPanelControl();

            if (Usuario.UsuarioYaRegistrado(txtUsuario.Text) == true)
            {
                if(ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    if (Usuario.ValidaConstrasenya(txtContrasenya.Text) == true)
                    {
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es erronea");
                        ConBD.CerrarConexion();
                    }
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("El usuario no está registrado");
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCreaCuenta frm = new FrmCreaCuenta();
            frm.Show();
            this.Hide();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar la cuenta registrada?", "Avisa", MessageBoxButtons.YesNo);
            //funcion de eliminar todo para pablo
        }
    }
}
