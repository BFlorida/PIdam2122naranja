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
using PiNaranja.Recursos;
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
        /// Borra la casa antigua y erronea y crea una nueva. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarCasa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNewHome.Text))
            {
                MessageBox.Show("Debes añadir un nombre a la nueva casa,\n no puedes tener un nombre de casa vacio,\n no puedes no tener casa");
            }
            else
            {

                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
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
                            Casa c = new Casa(txtNewHome.Text,usuario);
                            ConBD.AbrirConexion();
                            Casa.AgregaCasa(c);
                            ConBD.CerrarConexion();
                        }
                        MessageBox.Show("La vieja casa se ha eliminado junto con todos \nsus dispositivos y la nueva se ha creado con exito.");
                    }
                    




                }
                pcbCertificado panel = new pcbCertificado(usuario);
                panel.Show();
                this.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarBorrado_Click(object sender, EventArgs e)
        {
            pcbCertificado panel = new pcbCertificado(usuario);
            panel.Show();
            this.Dispose();
        }
    }
}
