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
        public Correo() { }
        //const string usuario = "myhomy.enterprises@gmail.com";
        //const string constrasenya = "mzpzwzvpegfyelue";

        public static string EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, string para, string asunto, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                //ensaje.Append(String.Format("Este correo ha sido enviado el día {0:dd/MM/yyyy} a las {0:HH/mm/ss} Hrs: \n\n", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("myhomy.enterprises@gmail.com");
                mail.To.Add(para);
                mail.Subject = asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("myhomy.enterprises@gmail.com", "mzpzwzvpegfyelue");
                smtp.EnableSsl = true;
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
