using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PInaranja.Clases
{
    //Clase Dispositivo. 
    internal class Dispositivo
    {
        private string nombre;
        private bool encendido;
        private double consumoBase;
        private double consumoPrecio;
        private string certificado;
        private string tipo;
        private string estancia;
        private string nomCasa;



        public string Nombre { get => nombre; set => nombre = value; }
        public bool Encendido { get => encendido; set => encendido = value; }
        public double ConsumoBase { get => consumoBase; set => consumoBase = value; }
        public string Estancia { get => estancia; set => estancia = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double ConsumoPrecio { get => consumoPrecio; set => consumoPrecio = value; }
        public string Certificado { get => certificado; set => certificado = value; }

        //Constructor para dispositivos que no esten en la base de datos.
        public Dispositivo(string nombre, string tipo, string estancia, string certificado)
        {
            this.nombre = nombre;
            this.encendido = false;
            this.consumoBase = CalcularConsumo(tipo,certificado);
            this.consumoPrecio = CalcularPrecio(consumoBase);
            this.certificado = certificado;
            this.tipo = tipo;
            this.estancia = estancia;
        }

        //Constuctor que recibe los datos de la base de datos.
        public Dispositivo(string nombre, bool encendido, double consumoBase, string estancia, string nomCasa)
        {
            this.nombre = nombre;
            this.encendido = encendido;
            this.consumoBase = consumoBase;
            this.estancia = estancia;
            this.nomCasa = nomCasa;
        }
        //Constructor por si acaso.
        public Dispositivo()
        {

        }
        
        /// <summary>
        /// Añade un dispositivo
        /// </summary>
        /// <param name="Objeto Dispositivo"></param>
        /// <returns>Número entero (0-1)que determinará si se ha creado el dispositivo o no</returns>
        public static int AgregarDispositivos(Dispositivo disp)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO dispositivos VALUES ('@nom','@enc','@cBa',@est','@cer','@nCa');");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", disp.nombre);
            comando.Parameters.AddWithValue("enc", disp.encendido);
            comando.Parameters.AddWithValue("cBa", disp.consumoBase);
            comando.Parameters.AddWithValue("est", disp.estancia);
            comando.Parameters.AddWithValue("nCa", disp.nomCasa);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        /// <summary>
        /// Elimina un dispositivo
        /// </summary>
        /// <param name="Objeto Dispositivo"></param>
        /// <returns>Número entero (0-1)que determinará si se ha eliminado el dispositivo o no</returns>
        public static int EliminarDispositivos(Dispositivo disp)
        {
            int retorno;

            string consulta = String.Format("DELETE FROM dispositivos WHERE nombreDispo = @nom;");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", disp.nombre);
            
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        /// <summary>
        /// Comprueba si existe el dispositivo.
        /// </summary>
        /// <param name="nombre del dispositivom(campo clave de Dispositivo)"></param>
        /// <returns>Devuelve true si ya existe el dispositivo. false si no existe. </returns>
        public static bool ValidarDispositivos(string nom)
        {
            string consulta = String.Format("Select nombreDispo FROM dispositivos WHERE nombreDispo = @nom;");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", nom);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

            //Ver como introducir
        public static int EditarDispositivo(string nombre, string tipo,string estancia, string certificado, string nomCasa)
        {
            int retorno;

            string consulta = String.Format("UPDATE dispositivo SET consumoBase = @cBa WHERE nombreDispo = @nom;");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", nombre);
            comando.Parameters.AddWithValue("cBa", CalcularConsumo(tipo,certificado));
            comando.Parameters.AddWithValue("est", estancia);
            comando.Parameters.AddWithValue("cer", certificado);
            comando.Parameters.AddWithValue("nCa", nomCasa);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        /// <summary>
        /// Enciende dispositivo.
        /// </summary>
        /// <param name="nombre del dispositivom(campo clave de Dispositivo)"></param>
        /// <returns>Número entero (0-1)que determinará si se ha eliminado el dispositivo o no</returns>
        public static int Encender(string nom)
        {
            int retorno;

            string consulta = String.Format("UPDATE dispositivo SET encendido = TRUE WHERE nombreDispo = @nom;");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", nom);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        /// <summary>
        /// Apaga dispositivo.
        /// </summary>
        /// <param name="nombre del dispositivom(campo clave de Dispositivo)"></param>
        /// <returns>Número entero (0-1)que determinará si se ha eliminado el dispositivo o no.</returns>
        public static int Apagar(string nom)
        {
            int retorno;

            string consulta = String.Format("UPDATE dispositivo SET encendido = FALSE WHERE nombreDispo = @nom;");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", nom);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        //Método alterar alternativo. 
        public static int AlterarEstado(string nom,bool enc)
        {
            int retorno;
            bool estado;
            string consulta;
            if (enc==false)
            {
                estado= true;
            }
            else
            {
                estado= false;
            }
            consulta = String.Format("UPDATE dispositivo SET encendido = @est WHERE nombreDispo = @nom;");
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", nom);
            comando.Parameters.AddWithValue("est", estado);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static double CalcularConsumo(string tipo, string certificado)
        {
            double consumoBase;
            switch (tipo)
            {
                case "Lavadora":
                    consumoBase = 330;
                    break;
                case "Horno":
                    consumoBase = 950;
                    break;
                case "Lavavajillas":
                    consumoBase = 980;
                    break;
                case "TV":
                    consumoBase = 475;
                    break;
                case "Luces":
                    consumoBase = 0.1;
                    break;
                case "Persianas":
                    consumoBase = 540;
                    break;
                case "Sistema de Riego":
                    consumoBase = 100;
                    break;
                default:
                    consumoBase = 0;
                    break;
            }
            switch (certificado)
            {
                case "A":
                    consumoBase *= 0.10;
                    break;
                case "B":
                    consumoBase *= 0.25;
                    break;
                case "C":
                    consumoBase *= 0.30;
                    break;
                case "D":
                    consumoBase *= 0.35;
                    break;
                case "E":
                    consumoBase *= 0.47;
                    break;
                case "F":
                    consumoBase *= 0.65;
                    break;
                case "G":
                    consumoBase *= 0.90;
                    break;
            }

            return consumoBase;
        }

        private double CalcularPrecio(double consumoBase)
        {
            return consumoBase * 0.2;
        }


        public static List<Dispositivo> ListaDispositivos()
        {
            List<Dispositivo> lista = new List<Dispositivo>();
            String consulta = String.Format("SELECT * FROM dispositivo;");
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Dispositivo(reader.GetString(0), reader.GetBoolean(1), reader.GetDouble(2),
                    reader.GetString(3), reader.GetString(4)));
            }
            return lista;
        }


    }
}
