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
        //Atributos que pasan el nombre del usuario y el nombre de la casa de un formulario a otro. 
        //Esto lo empleamos en casi todos los formularios. 
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
            lblnamehouse.Text = casa.ToString();
            Refrescar();
        }

        DateTime ahora = DateTime.Now;
        DateTime final;
        string[] fecha = new string[3];

        //Otro array de tiempo para un posible segundo temporizador.
        //DateTime ahora2 = DateTime.Now;
        //DateTime final2;
        //string[] fecha2 = new string[3];

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        //carga los idiomas
        private void AplicarIdioma()
        {
            this.Text = Recursos.Idioma.FrmPanelControl;
            lblTipo.Text = Recursos.Idioma.lblTipo;
            grbAnyadirDispositivo.Text = Recursos.Idioma.grbAnyadirProducto;
            lblNombreDis.Text = Recursos.Idioma.lblNombreDis;
            //lblCerti1.Text = Recursos.Idioma.lblEstancia;
            lblEstancia.Text = Recursos.Idioma.lblEstancia;
            btnAgregarDispositivo.Text = Recursos.Idioma.btnAgregarDispositivo;
            lblDispositivosRegistrados.Text = Recursos.Idioma.lblEstanciasRegistradas;
            //lblClick.Text = Recursos.Idioma.lblClick;
            lblIdioma.Text = Recursos.Idioma.lblIdioma;
            btnEncender.Text = Recursos.Idioma.btnEncender;
            btnApagar.Text = Recursos.Idioma.btnApagar;
            lblDispositivo.Text = Recursos.Idioma.lblDispositivo;
            lblCertificado2.Text = Recursos.Idioma.lblCertificado2;
            lblW2.Text = Recursos.Idioma.lblW2;
            btnModificar.Text = Recursos.Idioma.btnModificar;
            btnEliminar.Text = Recursos.Idioma.btnEliminar;
            lblTipo2.Text = Recursos.Idioma.lblTipo;
            lblTipo.Text = Recursos.Idioma.lblTipo;
            lblCerti1.Text = Recursos.Idioma.lblCertificado2;
            lblEstancia2.Text = Recursos.Idioma.lblEstancia;
            btnParar.Text = Recursos.Idioma.btnParar;
            btnConfigurar.Text = Recursos.Idioma.btnconfigurar;
            btnMostrarDis.Text = Recursos.Idioma.btnMostrarDis;
            btnMostrarModDis.Text = Recursos.Idioma.btnMostrarModDis;
            btnTemporizador.Text = Recursos.Idioma.btnTemporizador;
            btnRegistro.Text = Recursos.Idioma.btnRegistro;
            btnEliminarCuenta.Text = Recursos.Idioma.btnEliminarCuenta;
            btnDeleteHome.Text = Recursos.Idioma.btnDeleteHome;
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
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cmbTipo.Text) || string.IsNullOrEmpty(cmbCertificado.Text))
            {
                MessageBox.Show("Debes introducir un nombre al dispositivo", "Aviso");
            }
            else
            {
                try
                {
                    ConBD.AbrirConexion();
                    Dispositivo disp = new Dispositivo(txtNombre.Text, cmbTipo.Text, cmbCertificado.Text, txtEstancia1.Text, casa);
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

            }
            Refrescar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDispositivos2.Text) || string.IsNullOrEmpty(cmbTipo2.Text) || string.IsNullOrEmpty(cmbCertificado2.Text))
            {
                MessageBox.Show("No pueden haber campos vacios al editar un dispositivo.");
            }
            else
            {
                try
                {
                    ConBD.AbrirConexion();
                    Dispositivo disp = new Dispositivo(cmbDispositivos2.Text, cmbTipo2.Text, cmbCertificado2.Text, txtEstancia2.Text, casa);
                    Dispositivo.EditarDispositivo(disp);
                    MessageBox.Show("Dispositivo modificado con éxito.");
                    ConBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ConBD.CerrarConexion();
                }
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
            if (grbModificar.Visible == true)
            {
                grbModificar.Visible = false;
            }
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

            if (grbModificar.Visible)
            {
                grbModificar.Visible = false;
            }
            else
            {
                grbModificar.Visible = true;
            }
            if (grbAnyadirDispositivo.Visible)
            {
                grbAnyadirDispositivo.Visible = false;
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            FrmRegistro reg = new FrmRegistro(usuario);
            reg.Refrescar();
            reg.Show();
            this.Hide();

        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTemp1.Text))
            {
                MessageBox.Show("No puede iniciar el temporizador sin seleccionar un dispositivo de la tabla");
            }
            else
            {
                string temp = mtxtTemp.Text;
                fecha = temp.Split(':');
                if (string.IsNullOrEmpty(fecha[0]) || string.IsNullOrEmpty(fecha[1]) || string.IsNullOrEmpty(fecha[2]))
                {
                    MessageBox.Show("No puede iniciar el temporizador sin indicar un tiempo");
                }
                else
                {
                    DateTime hoy = DateTime.Now;
                    final = new DateTime(ahora.Year, ahora.Month, ahora.Day,
                    Convert.ToInt32(fecha[0]), Convert.ToInt32(fecha[1]),
                    Convert.ToInt32(fecha[2]) + 1);
                    if (hoy < final)
                    {
                        tmrCrono.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El tiempo introducido no puede ser inferior al actual.");
                    }
                }

            }
            Refrescar();

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
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    Dispositivo dispo = new Dispositivo();
                    dispo = Dispositivo.ObtenerDatosDispo(txtTemp1.Text);

                    ConBD.CerrarConexion();
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();
                        Dispositivo.AlterarEstado(txtTemp1.Text, dispo.Encendido);
                        ConBD.CerrarConexion();
                        if (dispo.Encendido == true)
                        {
                            //Instanciamos un objeto registro
                            Registro reg = new Registro();
                            if (ConBD.Conexion != null)
                            {
                                ConBD.AbrirConexion();
                                //Obtenemos la fila a la que pertence el dispositivo seleccionado. 
                                int fila = Registro.ObtenerFila(txtTemp1.Text);
                                ConBD.CerrarConexion();
                                if (fila != 0)
                                {
                                    //Si el valor es distinto de 0 significa que ha encontrado un regisro. 
                                    if (ConBD.Conexion != null)
                                    {
                                        ConBD.AbrirConexion();
                                        //Obtenemos todos los datos de la fila seleccionada. 
                                        reg = Registro.ObtenerRegistro(fila);
                                        ConBD.CerrarConexion();
                                        //Asignamos a seg el valor que devuelve el método. (en segundos.)
                                        int seg = Registro.Tiempo(reg);
                                        //Pasamos el consumo de vatios por hora al consumo de vatios por segundo. 
                                        double vatiosXs = Registro.CalcularConsumoSegundo(dispo.ConsumoBase);
                                        //Pasamos el consumo de euros por hora al consumo de euros por segundo. 
                                        double precioXs = Registro.CalcularPrecioSegundo(dispo.ConsumoPrecio);
                                        if (ConBD.Conexion != null)
                                        {
                                            double num;
                                            //Instanciamos un registro y le asignamos valores. 
                                            Registro r = new Registro();
                                            r.Dispo = txtTemp1.Text;
                                            r.Estado = false;
                                            r.Fecha = DateTime.Now;
                                            //Obtenemos la hora del label del reloj. 
                                            r.Hora = TimeSpan.Parse(lblReloj.Text);
                                            //Asignamos a num los vatios que se han consumido durante los segundos que a estado encendido.
                                            num = (vatiosXs * seg);
                                            r.TotalConsumo = Math.Round(num, 2);
                                            //Asignamos a num los euros que se han consumido durante los segundos que a estado encendido.
                                            num = (precioXs * seg);
                                            r.TotalPrecio = Math.Round(num, 2);
                                            ConBD.AbrirConexion();
                                            //Agregamos el registro a registros. 
                                            Registro.AgregarRegistro(r);
                                            ConBD.CerrarConexion();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (ConBD.Conexion != null)
                            {
                                //Crea un objeto registro, y le asignamos sus valores
                                Registro r = new Registro();
                                r.Dispo = txtTemp1.Text;
                                r.Estado = true;
                                r.Fecha = DateTime.Now;
                                //Obtenemos la hora en el momento de pulsar el botón
                                r.Hora = TimeSpan.Parse(lblReloj.Text);
                                r.TotalConsumo = 0;
                                r.TotalPrecio = 0;
                                ConBD.AbrirConexion();
                                //Registramos el registro. 
                                Registro.AgregarRegistro(r);
                                ConBD.CerrarConexion();
                            }
                        }

                    }
                }

            }
            Refrescar();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion inicio = new FrmInicioSesion();
            this.Dispose();
            inicio.Show();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult borrado = MessageBox.Show("Vas a borrar la cuenta.",
            "\n¿Estás seguro de borrarla?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (borrado == DialogResult.Yes)
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    Usuario.EliminaUsuario(usuario);
                    ConBD.CerrarConexion();
                    MessageBox.Show("Cuenta Eliminada");
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
                dtv.DataSource = Dispositivo.ListaDispositivos1(casa);
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
                lista = Dispositivo.ListaDispositivos2(casa);
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }


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
            if (string.IsNullOrEmpty(cmbDispositivos2.Text))
            {
                MessageBox.Show("Tienes que seleccionar un dipositivo para borrarlo.");
            }
            else
            {
                try
                {
                    Dispositivo dispo = new Dispositivo();
                    dispo.Nombre = cmbDispositivos2.Text;
                    ConBD.AbrirConexion();
                    Dispositivo.EliminarDispositivos(cmbDispositivos2.Text);
                    ConBD.CerrarConexion();
                    MessageBox.Show("Dispositivo eliminado con éxito.");
                    Refrescar();

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
                txtTemp1.Text = "";
            }
            Refrescar();
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
            grbAnyadirDispositivo.Visible = false;
            grbModificar.Visible = true;
            grbtemporizadores.Visible = true;


            Refrescar();
        }


        /// <summary>
        /// Enciende el dispositivo y registra encendido en registros y en el log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDispositivos2.Text) != true)
            {
                //Si el dispositivo que está en el campo de texto existe. 
                Dispositivo dispo = new Dispositivo();
                if (ConBD.Conexion != null)
                {
                    //Obtiene datos del dispositivo seleccionado. 
                    ConBD.AbrirConexion();
                    dispo = Dispositivo.ObtenerDatosDispo(cmbDispositivos2.Text);
                    ConBD.CerrarConexion();
                    if (dispo.Encendido != true)
                    {
                        //Si el dispositivo está apagado
                        if (ConBD.Conexion != null)
                        {
                            ConBD.AbrirConexion();
                            //Lo enciende
                            Dispositivo.Encender(cmbDispositivos2.Text);
                            ConBD.CerrarConexion();
                            //Crea un objeto reguistro

                            if (ConBD.Conexion != null)
                            {
                                //Crea un objeto registro, y le asignamos sus valores
                                Registro r = new Registro();
                                r.Dispo = cmbDispositivos2.Text;
                                r.Estado = true;
                                r.Fecha = DateTime.Now;
                                //Obtenemos la hora en el momento de pulsar el botón
                                r.Hora = TimeSpan.Parse(lblReloj.Text);
                                r.TotalConsumo = 0;
                                r.TotalPrecio = 0;
                                ConBD.AbrirConexion();
                                //Registramos el registro. 
                                Registro.AgregarRegistro(r);
                                ConBD.CerrarConexion();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El dispositivo ya está encendido.", "Aviso");
                    }
                }
            }
            //Recargamos el Data grid View. 
            Refrescar();
        }



        /// <summary>
        /// Apaga el dispositivo y registra apagado en registros y en el log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDispositivos2.Text) != true)
            {
                //Comprueba si el campo de texto hay valores. 
                Dispositivo dispo = new Dispositivo();
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    //Obtiene los datos de dispositivo. 
                    dispo = Dispositivo.ObtenerDatosDispo(cmbDispositivos2.Text);
                    ConBD.CerrarConexion();
                    if (dispo.Encendido == true)
                    {
                        //Si el Dispositivo está encendido. 
                        if (ConBD.Conexion != null)
                        {
                            ConBD.AbrirConexion();
                            //Apagamos el dispositivo.
                            Dispositivo.Apagar(cmbDispositivos2.Text);
                            ConBD.CerrarConexion();
                        }
                        //Instanciamos un objeto registro
                        Registro reg = new Registro();
                        if (ConBD.Conexion != null)
                        {
                            ConBD.AbrirConexion();
                            //Obtenemos la fila a la que pertence el dispositivo seleccionado. 
                            int fila = Registro.ObtenerFila(cmbDispositivos2.Text);
                            ConBD.CerrarConexion();
                            if (fila != 0)
                            {
                                //Si el valor es distinto de 0 significa que ha encontrado un regisro. 
                                if (ConBD.Conexion != null)
                                {
                                    ConBD.AbrirConexion();
                                    //Obtenemos todos los datos de la fila seleccionada. 
                                    reg = Registro.ObtenerRegistro(fila);
                                    ConBD.CerrarConexion();
                                    //Asignamos a seg el valor que devuelve el método. (en segundos.)
                                    int seg = Registro.Tiempo(reg);
                                    //Pasamos el consumo de vatios por hora al consumo de vatios por segundo. 
                                    double vatiosXs = Registro.CalcularConsumoSegundo(dispo.ConsumoBase);
                                    //Pasamos el consumo de euros por hora al consumo de euros por segundo. 
                                    double precioXs = Registro.CalcularPrecioSegundo(dispo.ConsumoPrecio);
                                    if (ConBD.Conexion != null)
                                    {
                                        double num;
                                        //Instanciamos un registro y le asignamos valores. 
                                        Registro r = new Registro();
                                        r.Dispo = cmbDispositivos2.Text;
                                        r.Estado = false;
                                        r.Fecha = DateTime.Now;
                                        //Obtenemos la hora del label del reloj. 
                                        r.Hora = TimeSpan.Parse(lblReloj.Text);
                                        //Asignamos a num los vatios que se han consumido durante los segundos que a estado encendido.
                                        num = (vatiosXs * seg);
                                        r.TotalConsumo = Math.Round(num, 2);
                                        //Asignamos a num los euros que se han consumido durante los segundos que a estado encendido.
                                        num = (precioXs * seg);
                                        r.TotalPrecio = Math.Round(num, 2);
                                        ConBD.AbrirConexion();
                                        //Agregamos el registro a registros. 
                                        Registro.AgregarRegistro(r);
                                        ConBD.CerrarConexion();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El dispositivo ya se encuentra apagado.", "Aviso");
                    }
                }
            }
            Refrescar();
        }

        private void dtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                grbtemporizadores.Visible = true;
                txtTemp1.Text = dtv.Rows[n].Cells[0].Value.ToString();
            }
        }


        private void txtTemp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFaltan_Click(object sender, EventArgs e)
        {

        }

        private void btnTemporizador_Click(object sender, EventArgs e)
        {
            if (grbAnyadirDispositivo.Visible)
            {
                grbAnyadirDispositivo.Visible = false;
            }
            if (grbModificar.Visible)
            {
                grbModificar.Visible = false;
            }
            if (grbtemporizadores.Visible)
            {
                if (grbModificar.Visible || grbAnyadirDispositivo.Visible)
                {
                    grbtemporizadores.Visible = true;
                }
                else
                {
                    grbtemporizadores.Visible = false;
                }

            }
            else
            {
                grbtemporizadores.Visible = true;
            }

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreDis_Click(object sender, EventArgs e)
        {

        }

        private void lblReloj_Click(object sender, EventArgs e)
        {

        }

        //Obtenemos el nombre del dispositivo haciendo click en una cualquier celda del Data grid view
        private void dtv_CellClick(object sender, DataGridViewCellEventArgs e)
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

                grbtemporizadores.Visible = true;
                txtTemp1.Text = dtv.Rows[n].Cells[0].Value.ToString();

                grbAnyadirDispositivo.Visible = false;
                grbModificar.Visible = true;
                grbtemporizadores.Visible = true;
            }
        }
    }
}
