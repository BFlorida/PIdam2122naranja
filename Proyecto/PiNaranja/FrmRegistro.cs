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
    }
}
