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
        
        private static MySqlConnection instancia = null;
        
        private static readonly object padlock = new object();

        
        private ConBD() { }

       
        public static MySqlConnection Conexion
        {
            get
            {
                
                lock (padlock)
                {
                    
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        
                        string server = "server=myhomy.cdgeb6sovbed.us-east-1.rds.amazonaws.com;";
                        string database = "database=my_homy;";
                        string usuario = "uid=naranjitoteam;";
                        string password = "pwd=PIdamNaranjito1234!;";
                        instancia.ConnectionString = server + database + usuario + password;
                    }
                    
                    return instancia;
                }
            }
        }

        
        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }

        
        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }



    }
}
