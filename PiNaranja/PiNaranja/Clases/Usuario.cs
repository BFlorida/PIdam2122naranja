using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PInaranja.Clases
{
    class Usuario
    {
        private int id_usuario;
        private string nombre;
        private string apellido;
        private string correo;
        private string contrasenya;
        private bool conectado = false;

        public int Id_usuario { get { return id_usuario; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string Contrasenya { get { return contrasenya; } }
        private bool Conectado { get { return conectado; } }

        //parametrizamos todos los atributos
        public Usuario(string nom, string ap, string email, string contra, bool con)
        {
            this.nombre = nom;
            this.apellido = ap;
            this.correo = email;
            this.contrasenya = contra;
            this.conectado = con;
        }
        public Usuario(string nom, string ap, string email, string contra)
        {
            this.nombre = nom;
            this.apellido = ap;
            this.correo = email;
            this.contrasenya = contra;
            this.conectado = false;
        }

        //Constructor sobrecargado sin parámetros
        public Usuario() { }

        public static int AgregarUsuario(Usuario usu)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO usuario (nombre_Usu,apellido_Usu,correo,contrasenya,conectado) VALUES " +
                "('@nom','@ape','@co','@con')");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("nom", usu.nombre);
            comando.Parameters.AddWithValue("ape",usu.apellido);
            comando.Parameters.AddWithValue("co",usu.correo);
            comando.Parameters.AddWithValue("con",usu.contrasenya);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int EliminaUsuario(string email, string contra)
        {
            //se tiene que rehacer esta parte para que se elimine todo lo registrao para el usuario
            int retorno;
            string consulta = String.Format("DELETE FROM usuario WHERE correo='{0}' AND contrasenya='{1}'", email, contra);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static bool ValidaConstrasenya(string contra)
        {

            string consulta = String.Format("SELECT correo FROM usuario WHERE contrasenya='{0}'", contra);

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

        public static bool UsuarioYaRegistrado(string contra)
        {
            string consulta = String.Format("SELECT * FROM usuario" +
            " WHERE contrasenya='{0}'", contra);

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
