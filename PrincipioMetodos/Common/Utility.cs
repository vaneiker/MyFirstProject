using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web;

namespace PrincipioMetodos.Common
{
    public static class Utility
    {
        public static bool SendEmailBienvenida(string bodymessage, string emailTo, string subject, string bcc = "")
        {
            try
            {


                string TechnicianEmail = ConfigurationManager.AppSettings["TechnicianEmail"].ToString();
                string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
                string SMTPFrom = ConfigurationManager.AppSettings["SMTPFrom"].ToString();
                string SMTPPass = ConfigurationManager.AppSettings["SMTPPass"].ToString();
                int SMTPPort = int.Parse(ConfigurationManager.AppSettings["SMTPPort"].ToString());

                Boolean SMTPEnableSsl = Boolean.Parse(String.IsNullOrEmpty(ConfigurationManager.AppSettings["SMTPEnableSsl"]) ? "false" : ConfigurationManager.AppSettings["SMTPEnableSsl"]);

                var client = new SmtpClient(SMTPServer, SMTPPort)
                {
                    Credentials = new NetworkCredential(TechnicianEmail.ToString(), SMTPPass)
                   ,
                    EnableSsl = SMTPEnableSsl
                    // ,UseDefaultCredentials = SMTPUseDefaultCredentials //esto da error cuando esta false;

                };

                if (string.IsNullOrWhiteSpace(emailTo)) { emailTo = TechnicianEmail; }
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(SMTPFrom, emailTo.ToString());

                if (bcc != "")
                {
                    message.Bcc.Add(bcc);
                }
                message.Subject = subject;
                string mensaje = bodymessage;

                //message.Body = mensaje;
                message.IsBodyHtml = true;

                //create Alrternative HTML view
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, null, "text/html");

                ////Add Image
                //LinkedResource theEmailImage = new LinkedResource(HttpContext.Current.Server.MapPath("~/Templates/FotoMisael.png"));
                //theEmailImage.ContentId = "misaelfoto";

                ////Add the Image to the Alternate view
                //htmlView.LinkedResources.Add(theEmailImage);

                ////Add view to the Email Message
                message.AlternateViews.Add(htmlView);
                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string CapitalizarPrimeraLetra(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

        public static int EDAD_EMPLEADO(DateTime fechaNacimiento)
        {

            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        public static decimal AFP(decimal sueldobruto)
        {
            return sueldobruto * 3.84m / 100;
        }

        public static decimal ARS(decimal sueldobruto)
        {
            return sueldobruto * 2.04m / 100;
        }

        public static decimal IRS(decimal sueldobruto)
        {
            return sueldobruto * 12.04m / 100m;
        }

        public static decimal DobleSueldo(decimal totalacumulado)
        {
            return totalacumulado / 12;
        }

        public static string EncriptarAES(string texto, string clave)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // La clave debe tener 16, 24 o 32 bytes de longitud
                aesAlg.Key = Encoding.UTF8.GetBytes(clave.PadRight(16)); // Forzamos 16 caracteres en este caso
                aesAlg.IV = new byte[16]; // IV de 16 bytes con ceros

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(texto);
                        }
                        byte[] encrypted = msEncrypt.ToArray();
                        return Convert.ToBase64String(encrypted);
                    }
                }
            }
        }

        public static string DesencriptarAES(string textoEncriptado, string clave)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // La clave debe tener 16, 24 o 32 bytes de longitud
                aesAlg.Key = Encoding.UTF8.GetBytes(clave.PadRight(16)); // Forzamos 16 caracteres en este caso
                aesAlg.IV = new byte[16]; // El mismo IV que se usó para encriptar

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(textoEncriptado)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
