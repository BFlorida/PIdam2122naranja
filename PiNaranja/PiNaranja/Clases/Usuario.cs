using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PInaranja.Clases
{
    class Usuario
    {
        private string nombre;
        private string correo;
        private string contrasenya;
        private bool conectado = false;
        private int codigo;
        private bool validado;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string Contrasenya { get { return contrasenya; } set { contrasenya = value; } }
        private bool Conectado { get { return conectado; } set { conectado = value; } }
        public int Codigo { get => codigo; set => codigo = value; }
        public bool Validado { get => validado; set => validado = value; }


        //parametrizamos todos los atributos
        public Usuario(string nom, string email, string contra, bool con)
        {
            this.nombre = nom;
            this.correo = email;
            this.contrasenya = contra;
            this.conectado = con;
        }
        public Usuario(string nom, string email, string contra)
        {
            this.nombre = nom;
            this.correo = email;
            this.contrasenya = contra;
            this.conectado = false;
        }

        //Constructor sobrecargado sin parámetros
        public Usuario() { }

            public static int AgregarUsuario(Usuario usu)
            {
                int retorno;

                string consulta = String.Format("INSERT INTO cuenta (nombreUsu,correo,contrasenya,conectado,codigo,validado) VALUES " +
                    "(@nom,@cor,@con,@conx,9999999,false)");

                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                comando.Parameters.AddWithValue("nom", usu.nombre);
                comando.Parameters.AddWithValue("cor", usu.correo);
                comando.Parameters.AddWithValue("con", usu.contrasenya);
                comando.Parameters.AddWithValue("conx", usu.conectado);
                retorno = comando.ExecuteNonQuery();

                return retorno;
            }

        public static int EliminaUsuario(string nombre)
        {
            int retorno;
            string consulta = String.Format("DELETE FROM cuenta WHERE nombreUsu='{0}';", nombre);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static bool ValidaConstrasenya(string contra)
        {

            string consulta = String.Format("SELECT correo FROM cuenta WHERE contrasenya='{0}'", contra);

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

        public static bool UsuarioYaRegistrado(string usu)
        {
            string consulta = String.Format("SELECT * FROM cuenta" +
            " WHERE nombreUsu='{0}'", usu);

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
        public static bool CorreoYaRegistrado(string correo)
        {
            string consulta = string.Format("SELECT * from cuenta" +
                "Where correo='@cor'");
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("@cor", correo);
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
        public static string ObtenerCasa(string usu)
        {
            string consulta = string.Format("SELECT nombreCasa from casa Where propietario = '{0}';", usu);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            //comando.Parameters.AddWithValue("@nom", usu);
            string reader = (string)comando.ExecuteScalar();
            return reader.ToString();
        }
        public static int GetCodigo(string usu)
        {
            int retorno = 0;
            string consulta = String.Format("SELECT codigo from cuenta Where nombreUsu = '{0}';",usu);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            //comando.Parameters.AddWithValue("@nom", usu);
            retorno = (int)comando.ExecuteScalar();
            return retorno;
        }
        public static int CambiaCodigo(string nom, int vCode)
        {
            int retorno = 0;

            string consulta = String.Format("UPDATE cuenta SET codigo = @vCode WHERE nombreUsu = @nom;");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("@nom", nom);
            comando.Parameters.AddWithValue("vCode", vCode);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static int ActivarVerificacion(string nom)
        {
            int retorno;

            string consulta = String.Format("UPDATE cuenta SET validado = 1 WHERE nombreUsu = @nom;");

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("@nom", nom);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static bool UsuarioValidado(string usu)
        {
            string consulta = String.Format("SELECT * FROM cuenta WHERE nombreUsu='{0}' AND validado=TRUE;",usu);

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            //comando.Parameters.AddWithValue("@nom", usu);
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
