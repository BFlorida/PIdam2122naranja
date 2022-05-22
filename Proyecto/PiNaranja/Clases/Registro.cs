using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using PiNaranja.Clases;
using PInaranja.Clases;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace PInaranja.Clases
{
    internal class Registro
    {
        #region - Atributos - Propiedades - Constructores -
        private int idlog;
        private bool estado;
        private DateTime fecha;
        private TimeSpan hora;
        private double totalConsumo;
        private double totalPrecio;
        private string dispo;


        //el autocorrector corrige los campos dos tres y cuatro 
        public int Idlog { get => idlog; set => idlog = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double TotalConsumo { get => totalConsumo; set => totalConsumo = value; }
        public string Dispo { get => dispo; set => dispo = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public double TotalPrecio { get => totalPrecio; set => totalPrecio = value; }

        public Registro(int idlog, string dispo, bool estado, DateTime fecha, TimeSpan tiemU, double totalCon, double totalPrecio)
        {
            this.idlog = idlog;
            this.dispo = dispo;
            this.estado = estado;
            this.fecha = fecha;
            this.hora = tiemU;
            this.totalConsumo = totalCon;
            this.totalPrecio = totalPrecio;

        }

        public Registro() { }

        #endregion

        #region - Métodos -

        /// <summary>
        /// Agrega registro de dispositivo
        /// </summary>
        /// <param name="reg">Registro</param>
        /// <returns> 1 si se ha insertado un registro</returns>
        public static int AgregarRegistro(Registro reg)
        {
            int retorno;
            //Insertamos un registro en la tabla registro. 
            string consulta = String.Format("INSERT INTO registro (dispo,estado,fecha,tiempoUso,totalConsumo,totalPrecio) VALUES " +
                "(@di,@est,@f,@ti,@tC,@tP)");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("di", reg.dispo);
            comando.Parameters.AddWithValue("est", reg.estado);
            comando.Parameters.AddWithValue("f", reg.fecha);
            comando.Parameters.AddWithValue("ti", reg.hora);
            comando.Parameters.AddWithValue("tC", reg.totalConsumo);
            comando.Parameters.AddWithValue("tP", reg.totalPrecio);
            retorno = comando.ExecuteNonQuery();
            //Añadimos un registro en el log txt.
            Log.Add("Insertado un registro en myHomy --> Nombre: " + reg.Idlog);

            return retorno;
        }

        /// <summary>
        /// Listar los registros
        /// </summary>
        /// <param name="casa">nombre de la casa</param>
        /// <returns>Lista de registros</returns>
        public static List<Registro> ListaRegistro(string casa)
        {
            List<Registro> list = new List<Registro>();
            //Selecciona registro con la casa específica. 
            String consulta = String.Format("SELECT r.idlog, r.dispo, r.estado, r.fecha, r.tiempoUso, r.totalConsumo, r.totalPrecio FROM registro r " +
                "INNER JOIN dispositivo d ON r.dispo = d.nombreDispo WHERE nCasa = '{0}' ORDER BY idlog; ", casa);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Registro(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetBoolean(2),
                    reader.GetDateTime(3),
                    reader.GetTimeSpan(4),
                    reader.GetDouble(5),
                    reader.GetDouble(6)));
            }
            return list;

        }


        /// <summary>
        /// Convierte el tiempo de un dateTime en segundos. (Cálculos del precio de la luz)
        /// </summary>
        /// <param name="reg">Registro</param>
        /// <returns>El tiempo convertido a segundos</returns>
        public static int Tiempo(Registro reg)
        {
            //Convierte en string la fecha y hora del objeto concatenandola y pasandolo a string. 
            string stiempoRegistro = reg.fecha.ToString("yyyy/MM/dd") + " " + reg.hora.ToString();
            //Convertimos el resultado en un DateTime
            DateTime dtTiempoRegistro = Convert.ToDateTime(stiempoRegistro);
            //Obtenemos la fecha y hora actuales. 
            DateTime fechaActual = DateTime.Now;
            //Creamos un TimesPan para calcular el lapso de tiempo. 
            TimeSpan tiempo = new TimeSpan();
            //Operación. 
            tiempo = fechaActual - dtTiempoRegistro;
            //
            int segundos = 0;
            segundos = (tiempo.Days * 86400) + (tiempo.Hours * 3600) + (tiempo.Minutes * 60) + (tiempo.Seconds);
            //Pasamos los dias, horas, minutos y segundos a segundos y lo sumamos para conseguir los segundos en total.
            //Lo devolvemos. 
            return segundos;
        }

        /// <summary>
        /// Calcula el consumo por segundo.
        /// </summary>
        /// <param name="vatios">vatios</param>
        /// <returns>cantidad de vatios por segundo. </returns>
        public static double CalcularConsumoSegundo(double vatios)
        {
            return vatios / 3600;
        }

        /// <summary>
        /// Calcula el precio por segundo.
        /// </summary>
        /// <param name="precio">Precio</param>
        /// <returns>el precio de vatios/segundo</returns>
        public static double CalcularPrecioSegundo(double precio)
        {
            return precio / 3600;
        }

        /// <summary>
        /// Obtiene la ultima fila de la tabla.
        /// </summary>
        /// <param name="nom">nombre de dispositivo a buscar. </param>
        /// <returns>el numero de la ultima fila.</returns>
        public static int ObtenerFila(string nom)
        {
            int fila = 1;
            String consulta = String.Format("SELECT MAX(idlog) FROM registro WHERE dispo = '{0}';", nom);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            //comando.Parameters.AddWithValue("nom", nom);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int num = 0;
                    num = reader.GetInt32(0);
                    fila = num;
                }
                reader.Close();
                return fila;
            }
            else
            {
                reader.Close();
                return 0;
            }

        }


        /// <summary>
        /// Selecciona un registro acorde a codigo de registro. 
        /// </summary>
        /// <param name="fila">numero de fila</param>
        /// <returns>Registro en concreto.</returns>
        public static Registro ObtenerRegistro(int fila)
        {
            Registro dispositivo = new Registro();
            String consulta = String.Format("SELECT * FROM registro WHERE idlog = '{0}'; ", fila);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            //comando.Parameters.AddWithValue("nom", nom);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                dispositivo = new Registro(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetBoolean(2),
                    reader.GetDateTime(3),
                    reader.GetTimeSpan(4),
                    reader.GetDouble(5),
                reader.GetDouble(6));
            }
            reader.Close();
            return dispositivo;
        }
        #endregion
    }
}
