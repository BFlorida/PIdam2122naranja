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
    public partial class pcbCertificado : Form
    {
        private string usuario;
        private string casa;
        private Dispositivo dispo = new Dispositivo();
        public pcbCertificado(string usu)
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
            
            Refrescar();
        }

        DateTime ahora = DateTime.Now;
        DateTime final;
        string[] fecha = new string[3];

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
            lblDispositivosRegistrados.Text = Recursos.Idioma.lblEstanciasRegistradas;
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ConBD.AbrirConexion();
                Dispositivo disp = new Dispositivo(cmbDispositivos2.Text, cmbTipo2.Text, cmbCertificado2.Text, txtEstancia2.Text, casa);
                Dispositivo.EditarDispositivo(disp);
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (grbtemporizadores.Visible == true)
            {
                grbtemporizadores.Visible = false;
            }
            else
            {
                grbtemporizadores.Visible = true;
            }
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
            if (ptbEst.Visible == true)
            {
                ptbEst.Visible = false;
            }
            else
            {
                ptbEst.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblDispositivosRegistrados.Visible == true && dtv.Visible == true && lblClick.Visible == true)
            {
                lblDispositivosRegistrados.Visible = false;
                dtv.Visible = false;
                lblClick.Visible = false;
            }
            else
            {
                lblDispositivosRegistrados.Visible = true;
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


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion inicio = new FrmInicioSesion();
            this.Dispose();
            inicio.Show();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult borrado = MessageBox.Show("Vas a borrar la cuenta",
            "\n¿Estás seguro de borrarla?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (borrado == DialogResult.Yes)
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    Usuario.EliminaUsuario(usuario);
                    ConBD.CerrarConexion();
                    MessageBox.Show("Borja Eliminado");
                    FrmInicioSesion inicio = new FrmInicioSesion();
                    this.Dispose();
                    inicio.Show();
                }
            }
        }

        private void btnDeleteHome_Click(object sender, EventArgs e)
        {
            FrmReemplazarCasa rcasa = new FrmReemplazarCasa(usuario);
            rcasa.Show();
            this.Hide();
        }

        
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

            //Dispositivo dispositivo = new Dispositivo();
            //MessageBox.Show(cmbDispositivos2.Text);
            //if (ConBD.Conexion != null)
            //{
            //    ConBD.AbrirConexion();
            //    dispositivo = Dispositivo.ObtenerDatosDispo(cmbDispositivos2.Text);
            //    ConBD.CerrarConexion();
            //}
            //cmbDispositivos2.Text = dispositivo.Nombre;
            //cmbCertificado2.Text = dispositivo.Certificado;
            //cmbTipo2.Text = dispositivo.Tipo;
            //txtW2.Text = dispositivo.ConsumoBase.ToString();
            //txtEuros2.Text = dispositivo.ConsumoPrecio.ToString();
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
                cmbDispositivos2.Text = "";
                cmbCertificado2.Text = "";
                cmbTipo2.Text = "";
                txtEstancia2.Text = "";
                txtW2.Text = "";
                txtEuros2.Text = "";


                
                Refrescar();
            }
        }

        private void cmbDispositivos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dispositivo dispo = new Dispositivo();
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                dispo = Dispositivo.ObtenerDatosDispo(cmbDispositivos2.Text);
                ConBD.CerrarConexion();
            }
            cmbCertificado2.Text = dispo.Certificado;
            cmbTipo2.Text = dispo.Tipo;
            txtEstancia2.Text = dispo.Estancia;
            txtW2.Text = dispo.ConsumoBase.ToString();
            txtEuros2.Text = dispo.ConsumoPrecio.ToString();
        }

        private void dtv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                cmbDispositivos2.Text = dtv.Rows[n].Cells[0].Value.ToString();
                cmbTipo2.Text = dtv.Rows[n].Cells[4].Value.ToString();
                cmbCertificado2.Text = dtv.Rows[n].Cells[6].Value.ToString();
                txtEstancia2.Text = dtv.Rows[n].Cells[3].Value.ToString();
                txtW2.Text = Dispositivo.CalcularConsumo(dtv.Rows[n].Cells[4].Value.ToString(), dtv.Rows[n].Cells[6].Value.ToString()).ToString();
                txtEuros2.Text = Dispositivo.CalcularPrecio(Convert.ToDouble(txtW2.Text)).ToString();
            }
            MessageBox.Show(cmbDispositivos2.Text + cmbTipo2.Text + cmbCertificado2.Text + txtEstancia.Text + txtW2.Text + txtEuros2.Text);


            Refrescar();
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Dispositivo.Encender(cmbDispositivos2.Text);
                ConBD.CerrarConexion();
            }
            Refrescar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Dispositivo.Apagar(cmbDispositivos2.Text);
                ConBD.CerrarConexion();
            }
            Refrescar();
        }

        private void dtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                grbtemporizadores.Visible = true;
                cmbTemp.Text = dtv.Rows[n].Cells[0].Value.ToString();
            }
        }
    }
}
