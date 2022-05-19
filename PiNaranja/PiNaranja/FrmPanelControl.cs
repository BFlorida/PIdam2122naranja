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
    //To do HAcer invisibles los label de temporizador antes de darle al boton para que no aparezca "faltan..."
    public partial class FrmPanelControl : Form
    {
        private string usuario;
        private string casa;
<<<<<<< HEAD
        private Dispositivo dispo = new Dispositivo();
=======
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
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
<<<<<<< HEAD
            lblnamehouse.Text = casa.ToString();
            Refrescar();
=======
            MessageBox.Show("" + usuario + casa);
            lblnamehouse.Text =  casa.ToString();
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
        }

        DateTime ahora = DateTime.Now;
        DateTime final;
        string[] fecha = new string[3];
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b

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
<<<<<<< HEAD
            lblDispositivosRegistrados.Text = Recursos.Idioma.lblEstanciasRegistradas;
=======
            lblEstanciasRegistradas.Text = Recursos.Idioma.lblEstanciasRegistradas;
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
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
<<<<<<< HEAD
            try
            {
                ConBD.AbrirConexion();
                Dispositivo disp = new Dispositivo(txtNombre.Text, cmbTipo.Text, cmbCertificado.Text, txtEstancia.Text, casa);
                Dispositivo.AgregarDispositivos(disp);
                ConBD.CerrarConexion();
                MessageBox.Show("Dispositivo agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConBD.CerrarConexion();
            }


            Refrescar();
=======
            Dispositivo disp = new Dispositivo();
            disp.Nombre = txtNombre.Text;
            disp.Tipo = cmbCertificado.Text;
            disp.Certificado = cmbCertificado.Text;
            disp.Encendido = false;
            disp.ConsumoBase = Dispositivo.CalcularConsumo(cmbTipo.Text,cmbCertificado.Text);
            Dispositivo.AgregarDispositivos(disp);
            Dispositivo.ListaDispositivos();
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (grbtemporizadores.Visible == true)
            {
                grbtemporizadores.Visible = false;
            }
            else
            {
                grbtemporizadores.Visible = true;
            }
=======

>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
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
<<<<<<< HEAD


=======
                
            
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
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
<<<<<<< HEAD
            if (lblDispositivosRegistrados.Visible == true && dtv.Visible == true && lblClick.Visible == true)
            {
                lblDispositivosRegistrados.Visible = false;
=======
            if(lblEstanciasRegistradas.Visible==true && dtv.Visible == true && lblClick.Visible==true)
            {
                lblEstanciasRegistradas.Visible = false;
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
                dtv.Visible = false;
                lblClick.Visible = false;
            }
            else
            {
<<<<<<< HEAD
                lblDispositivosRegistrados.Visible = true;
=======
                lblEstanciasRegistradas.Visible = true;
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
                dtv.Visible = true;
                lblClick.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD

=======
           
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
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

<<<<<<< HEAD
=======
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
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
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
=======
<<<<<<< HEAD
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b

        private void btnDeleteHome_Click(object sender, EventArgs e)
        {
            FrmReemplazarCasa rcasa = new FrmReemplazarCasa(usuario);
            rcasa.Show();
            this.Hide();
        }
<<<<<<< HEAD

        
        private void Refrescar()
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                dtv.DataSource = Dispositivo.ListaDispositivos1();
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
            List<Dispositivo> lista = new List<Dispositivo>();
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                lista = Dispositivo.ListaDispositivos2();
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
            cmbDispositivos2.Items.Clear();
            for (int i = 0; i < lista.Count; i++) { cmbDispositivos2.Items.Add(lista[i].Nombre); }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Dispositivo dispo = new Dispositivo();
                    dispo.Nombre = cmbDispositivos2.Text;
                    ConBD.AbrirConexion();
                    MessageBox.Show(cmbDispositivos2.Text);
                    Dispositivo.EliminarDispositivos(cmbDispositivos2.Text);
                    ConBD.CerrarConexion();
                    MessageBox.Show("Dispositivo eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ConBD.CerrarConexion();
                }
                Refrescar();
            }
        }

        private void cmbDispositivos2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
=======
=======
>>>>>>> 19e1441a09eab5b4558e68b0970ce930aec73bd9
>>>>>>> 83d387e8e56e510d28c0b4d3db53669ef61d935b
    }
}
