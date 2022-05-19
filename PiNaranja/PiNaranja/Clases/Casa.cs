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

        public string NombreCasa { get { return nombreCasa; } set { nombreCasa = value; } }
        public string Propietario { get { return propietario; } set { propietario = value; } }
        public Casa(string nomCasa, string prop)
        {
            this.nombreCasa = nomCasa;
            this.propietario = prop;
        }

        public Casa() { }


        public static int AgregaCasa(Casa cas)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO casa (nombrecasa,propietario) VALUES " +
                "('@nomCasa','@prop')");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nomCasa", cas.nombreCasa);
            comando.Parameters.AddWithValue("prop", cas.propietario);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int EliminaUsuario(string nomCasa, string prop)
        {
            //se tiene que rehacer esta parte para que se elimine todo lo registrao para el usuario
            int retorno;
            string consulta = String.Format("DELETE FROM casa WHERE nombrecasa='{0}' AND propietario='{1}', ON" +
                "DELETE CASCADE", nomCasa, prop);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static string ObtenerCasa(string usu)
        {
            string consulta = string.Format("SELECT nombreCasa from casa" +
                "Where propietario='@nom';");
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("@nom", usu);
            MySqlDataReader reader = comando.ExecuteReader();
            return reader.ToString();
        }
    }
}
