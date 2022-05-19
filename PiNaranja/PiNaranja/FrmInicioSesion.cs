using System;
using PInaranja.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using PiNaranja.Recursos;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PiNaranja
{
    public partial class FrmInicioSesion : Form
    {
        
        private string usuario;
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            

            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();

                if (Usuario.UsuarioYaRegistrado(txtUsuario.Text))
                {
                    ConBD.CerrarConexion();
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();

                        if (Usuario.ValidaConstrasenya(txtContrasenya.Text))
                        {
                            
                            ConBD.CerrarConexion();
                            if (ConBD.Conexion != null)
                            {
                                ConBD.AbrirConexion();
                                bool validado = Usuario.UsuarioValidado(txtUsuario.Text);
<<<<<<< HEAD
                                if (validado == true)
                                {
                                    usuario = txtUsuario.Text;
                                    ConBD.CerrarConexion();
                                    FrmPanelControl frmpc = new FrmPanelControl(usuario);
=======
                                MessageBox.Show(validado.ToString());
                                if (validado == true)
                                {
                                    usuario = txtUsuario.Text;
<<<<<<< HEAD
                                    ConBD.CerrarConexion();
                                    FrmPanelControl frmpc = new FrmPanelControl(usuario);
=======
                                    FrmPanelControl frmpc = new FrmPanelControl(usuario);
                                    ConBD.CerrarConexion();
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
                                    frmpc.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    usuario = txtUsuario.Text;
<<<<<<< HEAD
                                    ConBD.CerrarConexion();
                                    FrmVerificacion frmv = new FrmVerificacion(usuario);
=======
<<<<<<< HEAD
                                    ConBD.CerrarConexion();
                                    FrmVerificacion frmv = new FrmVerificacion(usuario);
=======
                                    FrmVerificacion frmv = new FrmVerificacion(usuario);
                                    ConBD.CerrarConexion();
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
                                    frmv.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña es erronea");
                            ConBD.CerrarConexion();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no está registrado");
                    ConBD.CerrarConexion();
                }
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

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Recursos.Idioma.FrmInicioSesion;
            lblUsuario.Text = Recursos.Idioma.lblUsuario;
            lblContraseña.Text = Recursos.Idioma.lblContraseña;
            lblIdioma.Text = Recursos.Idioma.lblIdioma;
            btnInicioSesion.Text = Recursos.Idioma.btnInicioSesion;
            btnCrearCuenta.Text = Recursos.Idioma.btnCrearCuenta;
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
