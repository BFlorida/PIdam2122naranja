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
    public partial class FrmPanelControl : Form
    {
        private string usuario;
        private string casa;
        public FrmPanelControl(string usu)
        {
            InitializeComponent();
            usuario = usu;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                casa = Casa.ObtenerCasa(usuario);
                ConBD.CerrarConexion();
            }
            lblFecha.Text = DateTime.Now.ToShortDateString();
            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
            MessageBox.Show("" + usuario + casa);
            lblnamehouse.Text =  casa.ToString();
        }

        DateTime ahora = DateTime.Now;
        DateTime final;
        string[] fecha = new string[3];
<<<<<<< HEAD

        DateTime ahora2 = DateTime.Now;
        DateTime final2;
        string[] fecha2 = new string[3];

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void AplicarIdioma()
        {
            this.Text = Recursos.Idioma.FrmPanelControl;
            lblTipo.Text = Recursos.Idioma.lblSelecHogar;
            grbAnyadirDispositivo.Text = Recursos.Idioma.grbAnyadirProducto;
            lblNombreDis.Text = Recursos.Idioma.lblNombreDis;
            lblTipo.Text = Recursos.Idioma.lblSelecHogar;
            lblCertificado.Text = Recursos.Idioma.lblEstanciaDispo;
            lblEstancia.Text = Recursos.Idioma.lblConsumoBase;
            btnAgregarDispositivo.Text = Recursos.Idioma.btnAgregarDispositivo;
            lblEstanciasRegistradas.Text = Recursos.Idioma.lblEstanciasRegistradas;
            lblClick.Text = Recursos.Idioma.lblClick;
            lblIdioma.Text = Recursos.Idioma.lblIdioma;
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



        private void btnAgregarDispositivo_Click(object sender, EventArgs e)
        {
            Dispositivo disp = new Dispositivo();
            disp.Nombre = txtNombre.Text;
            disp.Tipo = cmbCertificado.Text;
            disp.Certificado = cmbCertificado.Text;
            disp.Encendido = false;
            disp.ConsumoBase = Dispositivo.CalcularConsumo(cmbTipo.Text,cmbCertificado.Text);
            Dispositivo.AgregarDispositivos(disp);
            Dispositivo.ListaDispositivos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarDis_Click(object sender, EventArgs e)
        {
            if (grbAnyadirDispositivo.Visible == true)
            {
                grbAnyadirDispositivo.Visible = false;
            }
            else
            {
                grbAnyadirDispositivo.Visible = true;
            }
                
            
        }

        private void btnMostrarModDis_Click(object sender, EventArgs e)
        {
            if (grbModificar.Visible == true)
            {
                grbModificar.Visible = false;
            }
            else
            {
                grbModificar.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lblEstanciasRegistradas.Visible==true && dtv.Visible == true && lblClick.Visible==true)
            {
                lblEstanciasRegistradas.Visible = false;
                dtv.Visible = false;
                lblClick.Visible = false;
            }
            else
            {
                lblEstanciasRegistradas.Visible = true;
                dtv.Visible = true;
                lblClick.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            tmrCrono.Enabled = true;
        }

        private void btnConfigurar2_Click(object sender, EventArgs e)
        {
            tmrCrono2.Enabled = true;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            tmrCrono.Enabled = false;
        }

        private void btnParar2_Click(object sender, EventArgs e)
        {
            tmrCrono2.Enabled = false;
        }

        private void tmrCrono_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            string temp = mtxtTemp.Text;
            fecha = temp.Split(':');
            final = new DateTime(ahora.Year, ahora.Month, ahora.Day,
                Convert.ToInt32(fecha[0]), Convert.ToInt32(fecha[1]),
                Convert.ToInt32(fecha[2]));
            TimeSpan diferencia = new TimeSpan();
            diferencia = final - hoy;

            lblFaltan.Text = diferencia.Hours + ":" + diferencia.Minutes + ":"
                + (diferencia.Seconds + 1);

            if (lblFaltan.Text == "0:0:0")
            {
                tmrCrono.Enabled = false;
                MessageBox.Show("temporizador finalizado. myHomy apagará el dispositivo");
            }
        }

=======

        DateTime ahora2 = DateTime.Now;
        DateTime final2;
        string[] fecha2 = new string[3];

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void AplicarIdioma()
        {
            this.Text = Recursos.Idioma.FrmPanelControl;
            lblTipo.Text = Recursos.Idioma.lblSelecHogar;
            grbAnyadirDispositivo.Text = Recursos.Idioma.grbAnyadirProducto;
            lblNombreDis.Text = Recursos.Idioma.lblNombreDis;
            lblTipo.Text = Recursos.Idioma.lblSelecHogar;
            lblCertificado.Text = Recursos.Idioma.lblEstanciaDispo;
            lblEstancia.Text = Recursos.Idioma.lblConsumoBase;
            btnAgregarDispositivo.Text = Recursos.Idioma.btnAgregarDispositivo;
            lblEstanciasRegistradas.Text = Recursos.Idioma.lblEstanciasRegistradas;
            lblClick.Text = Recursos.Idioma.lblClick;
            lblIdioma.Text = Recursos.Idioma.lblIdioma;
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



        private void btnAgregarDispositivo_Click(object sender, EventArgs e)
        {
            Dispositivo disp = new Dispositivo();
            disp.Nombre = txtNombre.Text;
            disp.Tipo = cmbCertificado.Text;
            disp.Certificado = cmbCertificado.Text;
            disp.Encendido = false;
            disp.ConsumoBase = Dispositivo.CalcularConsumo(cmbTipo.Text,cmbCertificado.Text);
            Dispositivo.AgregarDispositivos(disp);
            Dispositivo.ListaDispositivos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarDis_Click(object sender, EventArgs e)
        {
            if (grbAnyadirDispositivo.Visible == true)
            {
                grbAnyadirDispositivo.Visible = false;
            }
            else
            {
                grbAnyadirDispositivo.Visible = true;
            }
                
            
        }

        private void btnMostrarModDis_Click(object sender, EventArgs e)
        {
            if (grbModificar.Visible == true)
            {
                grbModificar.Visible = false;
            }
            else
            {
                grbModificar.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lblEstanciasRegistradas.Visible==true && dtv.Visible == true && lblClick.Visible==true)
            {
                lblEstanciasRegistradas.Visible = false;
                dtv.Visible = false;
                lblClick.Visible = false;
            }
            else
            {
                lblEstanciasRegistradas.Visible = true;
                dtv.Visible = true;
                lblClick.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            tmrCrono.Enabled = true;
        }

        private void btnConfigurar2_Click(object sender, EventArgs e)
        {
            tmrCrono2.Enabled = true;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            tmrCrono.Enabled = false;
        }

        private void btnParar2_Click(object sender, EventArgs e)
        {
            tmrCrono2.Enabled = false;
        }

        private void tmrCrono_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            string temp = mtxtTemp.Text;
            fecha = temp.Split(':');
            final = new DateTime(ahora.Year, ahora.Month, ahora.Day,
                Convert.ToInt32(fecha[0]), Convert.ToInt32(fecha[1]),
                Convert.ToInt32(fecha[2]));
            TimeSpan diferencia = new TimeSpan();
            diferencia = final - hoy;

            lblFaltan.Text = diferencia.Hours + ":" + diferencia.Minutes + ":"
                + (diferencia.Seconds + 1);

            if (lblFaltan.Text == "0:0:0")
            {
                tmrCrono.Enabled = false;
                MessageBox.Show("temporizador finalizado. myHomy apagará el dispositivo");
            }
        }

>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
        private void tmrCrono2_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            string temp = mtxtTemp2.Text;
            fecha2 = temp.Split(':');
            final2 = new DateTime(ahora.Year, ahora.Month, ahora.Day,
                Convert.ToInt32(fecha2[0]), Convert.ToInt32(fecha2[1]),
                Convert.ToInt32(fecha2[2]));
            TimeSpan diferencia2 = new TimeSpan();
            diferencia2 = final2 - hoy;

            lblFaltan2.Text = diferencia2.Hours + ":" + diferencia2.Minutes + ":"
                + (diferencia2.Seconds + 1);

            if (lblFaltan2.Text == "0:0:0")
            {
                tmrCrono2.Enabled = false;
                MessageBox.Show("temporizador finalizado. myHomy apagará el dispositivo2");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion inicio = new FrmInicioSesion();
            this.Dispose();
            inicio.Show();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Usuario.EliminaUsuario(usuario);
                ConBD.CerrarConexion();
                MessageBox.Show("Usuario Eliminado");
                FrmInicioSesion inicio = new FrmInicioSesion();
                this.Dispose();
                inicio.Show();
            }

        }
<<<<<<< HEAD

        private void btnDeleteHome_Click(object sender, EventArgs e)
        {
            FrmReemplazarCasa rcasa = new FrmReemplazarCasa(usuario);
            rcasa.Show();
            this.Hide();
        }
=======
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
    }
}
