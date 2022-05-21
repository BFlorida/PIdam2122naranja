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


        public static int AgregarRegistro(Registro reg)
        {
            int retorno;

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

            Log.Add("Insertado un registro en myHomy --> Nombre: " + reg.Idlog);

            return retorno;
        }

        public static List<Registro> ListaRegistro(string casa)
        {
            List<Registro> list = new List<Registro>();
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
        /// 
        /// </summary>
        /// <param name="reg"></param>
        /// <returns></returns>
        
        public static int Tiempo(Registro reg)
        {
            //Convierte en string la fecha y hora del objeto concatenandola y pasandolo a string. 
            string stiempoRegistro = reg.fecha.ToString("yyyy/MM/dd") +" "+ reg.hora.ToString();
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
            segundos = (tiempo.Days * 86400)+(tiempo.Hours * 3600)+(tiempo.Minutes * 60)+(tiempo.Seconds);
            //Pasamos los dias, horas, minutos y segundos a segundos y lo sumamos para conseguir los segundos en total.
            //Lo devolvemos. 
            return segundos;
        }
        public static double CalcularConsumoSegundo(double vatios)
        {
            return vatios / 3600;
        }
        public static double CalcularPrecioSegundo(double precio)
        {
            return precio / 3600;
        }
        public static int ObtenerFila(string nom)
        {
            int fila =1;
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
    }
}
