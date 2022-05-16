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
        private static string path = Directory.GetCurrentDirectory();

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

        private static string GetNameFile()
        {
            string nombre = "";

            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_"
                + DateTime.Now.Day + ".txt";

            return nombre;
        }

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
    }
}
