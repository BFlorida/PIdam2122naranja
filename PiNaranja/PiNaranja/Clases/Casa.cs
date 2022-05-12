using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PInaranja.Clases
{
    internal class Casa
    {

        private int id_casa;
        private string nombre;

        Usuario user = new Usuario();

        public int Id_casa { get { return id_casa; } }
        public string Nombre { get { return nombre; } set { nombre=value; } }
        public Usuario User { get { return user; } set { user = value; } }

        public Casa(string nom, Usuario usu)
        {
            this.nombre = nom;
            this.user = usu;
        }

        public Casa() { }


        public int AgregarCasa(Casa c)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO casa (nombre_Casa) VALUES " +
                "('{0}')", c.nombre);

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int EliminarCasa(string nombre, Usuario usu) //duda con parametrizar usuario
        {
            int retorno;
            string consulta = String.Format("DELETE FROM casa WHERE nombre='{0}' AND fk_usuario='{1}'", nombre, usu);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public bool CasaYaRegistrada(string nombre)
        {
            string consulta = String.Format("SELECT * FROM casa" +
            " WHERE nombre='{0}'", nombre);

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
