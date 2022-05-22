using System;
using PInaranja.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using PiNaranja.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiNaranja
{
    public partial class FrmReemplazarCasa : Form
    {
        string usuario;
        public FrmReemplazarCasa(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }
        /// <summary>
        /// Borra la casa antigua y erronea y crea una nueva en su lugar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarCasa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewHome.Text))
            {
                MessageBox.Show("Debes añadir un nombre a la nueva casa,\n no puedes tener un nombre de casa vacio,\n no puedes no tener casa");
            }
            else
            {

                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    //Comporueba que ya exista la casa que se pretende crear. 
                    bool casaregistrada = Casa.CasaYaRegistrada(txtNewHome.Text);
                    if (casaregistrada)
                    {
                        ConBD.CerrarConexion();
                        MessageBox.Show("El nombre de la nueva casa ya está en uso.");
                    }
                    else
                    {
                        ConBD.CerrarConexion();
                        if (ConBD.Conexion != null)
                        {
                            ConBD.AbrirConexion();
                            Casa.EliminaCasa(usuario);
                            ConBD.CerrarConexion();
                        }
                        if (ConBD.Conexion != null)
                        {
                            Casa c = new Casa(txtNewHome.Text, usuario);
                            ConBD.AbrirConexion();
                            Casa.AgregaCasa(c);
                            ConBD.CerrarConexion();
                        }
                        MessageBox.Show("La vieja casa se ha eliminado junto con todos \nsus dispositivos y la nueva se ha creado con exito.");
                    }





                }
                FrmPanelControl panel = new FrmPanelControl(usuario);
                panel.Show();
                this.Dispose();
            }
        }

        private void btnCancelarBorrado_Click(object sender, EventArgs e)
        {
            FrmPanelControl panel = new FrmPanelControl(usuario);
            panel.Show();
            this.Dispose();
        }

        private void FrmReemplazarCasa_Load(object sender, EventArgs e)
        {
            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Resources.Idioma.frmReemplazarCasa;
            lblIdioma.Text = Resources.Idioma.lblIdioma;
            lblNuevaCasa.Text = Resources.Idioma.lblNuevaCasa;
            btnActualizarCasa.Text = Resources.Idioma.btnActualizarCasa;
            btnCancelarBorrado.Text = Resources.Idioma.btnCancelar;
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
