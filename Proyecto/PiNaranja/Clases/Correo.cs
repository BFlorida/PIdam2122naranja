using System;
using System.Collections.Generic;
using PiNaranja.Clases;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace PiNaranja.Clases
{
    public class Correo
    {
        //Clase que gestiona el correo corporativo de myHomy Enterprises para la validación de las nuevas cuentaS. 
        public Correo() { }
        //const string usuario = "myhomy.enterprises@gmail.com";
        //const string constrasenya = "mzpzwzvpegfyelue";


        /// <summary>
        /// Envia un correo de myhomy Enterprises al correo
        /// </summary>
        /// <param name="Mensaje">Cuerpo el mail con el codigo aleatorio de verificacion</param>
        /// <param name="FechaEnvio">Fecha de hoy</param>
        /// <param name="para">usuario al que va enviado (Viene del formulario de verificacion o de recuperar cuenta)</param>
        /// <param name="asunto">Asunto fijo</param>
        /// <param name="Error">Mensaje de error</param>
        /// <returns></returns>
        public static string EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, string para, string asunto, out string Error)
        {
            //Mensaje de error vacio para utilizarlo si se llega a dar un error.
            Error = "";
            try
            {
                //Añade al cuerpo del mail dos lineas vacías
                Mensaje.Append(Environment.NewLine);
                //ensaje.Append(String.Format("Este correo ha sido enviado el día {0:dd/MM/yyyy} a las {0:HH/mm/ss} Hrs: \n\n", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                //Instancia de la clase mailmessage (poder crear un mail)
                MailMessage mail = new MailMessage();
                //Añade los campos del mail. Remitente, destinatario, asunto, cuerpo.
                mail.From = new MailAddress("myhomy.enterprises@gmail.com");
                mail.To.Add(para);
                mail.Subject = asunto;
                mail.Body = Mensaje.ToString();
                //Instancia de cliente de mail con las credenciales de gmail. 
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                //Datos de conexion con el servidor.
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                //Le pasamos las credenciales de correo de Myhomy(correo - contraseña )
                smtp.Credentials = new NetworkCredential("myhomy.enterprises@gmail.com", "mzpzwzvpegfyelue");
                smtp.EnableSsl = true;
                //Enviamos el correo. 
                smtp.Send(mail);
                Error = "Éxito";
                return Error;
            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                return Error;
            }
        }
    }

}
