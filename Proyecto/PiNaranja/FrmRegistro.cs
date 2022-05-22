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
    public partial class FrmRegistro : Form
    {
        private string usuario;
        private string casa;
        public FrmRegistro(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                casa = Casa.ObtenerCasa(usuario);
                ConBD.CerrarConexion();
            }
            Refrescar();

            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
        }



        //Recargamos el DGV para añadir nuevos registros. 
        public void Refrescar()
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                dtgRegistro.DataSource = Registro.ListaRegistro(casa);
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPanelControl panel = new FrmPanelControl(usuario);
            panel.Show();
            this.Hide();
        }

        private void AplicarIdioma()
        {
            this.Text = Resources.Idioma.frmRegistro;
            lblIdioma.Text = Resources.Idioma.lblIdioma;
            lblRegisto.Text = Resources.Idioma.lblRegistro;
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
