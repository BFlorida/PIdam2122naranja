using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiNaranja.Clases;

namespace PInaranja.Clases
{
    class Casa
    {
        private string nombreCasa;
        private string propietario;
        //Lista de dispositivos?
        public string NombreCasa { get { return nombreCasa; } set { nombreCasa = value; } }
        public string Propietario { get { return propietario; } set { propietario = value; } } //Nombre del propietario (Foreign Key hacia cuenta)
        public Casa(string nomCasa, string prop)
        {
            this.nombreCasa = nomCasa;
            this.propietario = prop;
        }

        public Casa() { }


        /// <summary>
        ///Agrega la casa del usuario
        /// </summary>
        /// <param casa="Cas">Objeto casa</param>
        /// <returns>Devuelve numero de control para determinar si se ha creado una casa 1 o no 0.</returns>
        public static int AgregaCasa(Casa cas)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO casa (nombrecasa,propietario) VALUES ('{0}','{1}')", cas.nombreCasa, cas.propietario);

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            //comando.Parameters.AddWithValue("nomCasa", cas.nombreCasa);
            //comando.Parameters.AddWithValue("prop", cas.propietario);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        /// <summary>
        ///Elimina casa
        /// </summary>
        /// <param string="prop">nombre del propietario</param>
        /// <returns>Devuelve numero de control para determinar si se ha eliminado una casa 1 o no 0.</returns>
        public static int EliminaCasa(string prop)
        {
            //se tiene que rehacer esta parte para que se elimine todo lo registrao para el usuario
            int retorno;
            string consulta = String.Format("DELETE FROM casa WHERE propietario='{0}';", prop);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        /// <summary>
        ///Comprueba si casa existe. 
        /// </summary>
        /// <param String="usu">Nombre del propietario de casa</param>
        /// <returns>Devuelve el nombre del propietario de la casa.</returns>
        public static string ObtenerCasa(string usu)
        {
            string consulta = string.Format("SELECT nombreCasa from casa Where propietario = '{0}';",usu);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            //comando.Parameters.AddWithValue("@nom", usu);
            string reader = (string)comando.ExecuteScalar();
            return reader.ToString();
        }


        /// <summary>
        ///Obtiene toda la informacion de casa. 
        /// </summary>
        /// <param string="casa">nombre de la casa</param>
        /// <returns>Devuelve true si la casa existe y false si no existe. </returns>
        public static bool CasaYaRegistrada(string casa)
        {
            string consulta = String.Format("SELECT * FROM casa WHERE nombreCasa='{0}'", casa);

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }


    }
}
