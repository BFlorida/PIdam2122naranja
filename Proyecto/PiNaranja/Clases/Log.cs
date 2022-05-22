using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PiNaranja.Clases
{
    public static class Log
    {
        #region - Atributos - Propiedades - Constructores -
        private static string path = Directory.GetCurrentDirectory();
        #endregion

        #region - Métodos - 


        /// <summary>
        /// Añade una entrada en el log
        /// </summary>
        /// <param name="sLog">Linea de registro</param>
        public static void Add(string sLog)
        {
            // CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";

            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();

        }
        /// <summary>
        /// Crear el nombre del archivo de log.
        /// </summary>
        /// <returns>cadena con nombre de archivo.txt</returns>
        private static string GetNameFile()
        {
            string nombre = "";

            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_"
                + DateTime.Now.Day + ".txt";

            return nombre;
        }

        /// <summary>
        /// Crear una carpeta para el log. 
        /// </summary>
        /// <exception cref="Exception"></exception>
        private static void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);

            }
        }
        #endregion
    }
}
