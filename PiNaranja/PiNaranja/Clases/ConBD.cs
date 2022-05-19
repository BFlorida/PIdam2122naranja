using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PInaranja.Clases
{
    internal class ConBD
    {
        // atributo privado - referencia al objeto que se va a crear.
        private static MySqlConnection instancia = null;
        // objeto a utilizar para el bloqueo (no es totalmente necesario en el patrón).
        private static readonly object padlock = new object();

        // Contructor privado.
        // No es público para evitar que cualquier otra clase pueda utilizarlo,
        // y por tanto se puedan instaciar objetos de la Clase ConexionBD desde fuera de esta clase.
        private ConBD() { }

        // Propiedad que permite el acceso de lectura (GET) a la conexión.
        // Si no existe el objeto se instancia (sólo una vez) y si existe se devuelve su referencia.
        public static MySqlConnection Conexion
        {
            get
            {
                // Se bloquea el objeto para garantizar que sólo un proceso accede a este código 
                // hasta que el bloqueo es liberado (en caso de utilizar threads -hilos-)
                lock (padlock)
                {
                    // Si no existe instancia del objeto conexión a la base de datos la creamos.
                    // En caso de existir instancia no se crea una nueva.
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        // Se define la cadena de conexión para la conexión.
                        string server = "server=myhomy.cdgeb6sovbed.us-east-1.rds.amazonaws.com;";
                        string database = "database=my_homy;";
                        string usuario = "uid=naranjitoteam;";
                        string password = "pwd=PIdamNaranjito1234!;";
                        instancia.ConnectionString = server + database + usuario + password;
                    }
                    // Se devuelve la instancia de conexión a la base de datos.
                    return instancia;
                }
            }
        }

        // Método público para abrir la conexión 
        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }

        // Método público para cerrar la conexión
        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }



    }
}
