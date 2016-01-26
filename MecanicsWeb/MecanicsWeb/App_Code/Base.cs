using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
/// <summary>
/// Summary description for Base
/// </summary>
public class Base : System.Web.UI.Page
{
	public Base()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void AlertaJS(string strJS)
    {
        StringBuilder js = new StringBuilder();
        js.AppendLine("alertify.alert('<b>" + HttpUtility.HtmlEncode(strJS) + "</b>');");
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "alertify", js.ToString(), true);
    }

    public void Enviar(string de, string para, string titulo, string cuerpo, string server, string cc, string pass, string email2)
    {
        /// <summary>
        /// Funcion que permite enviar los correos
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        try
        {
            string[] destinatarios = cc.Split(';');
            MailMessage htmlMessage;
            SmtpClient mySmtpClient;
            htmlMessage = new MailMessage();
            if (para != null) htmlMessage.To.Add(para);//PERSONA
            if (email2 != "") htmlMessage.To.Add(email2);//JEFE
            htmlMessage.From = new MailAddress(de);
            htmlMessage.Body = cuerpo;
            htmlMessage.Subject = titulo;
            htmlMessage.Priority = MailPriority.High;
            htmlMessage.IsBodyHtml = false;
            if (cc != "")
            {
                if (destinatarios.Length > 0)
                {
                    foreach (var destinatario in destinatarios)
                    {
                        htmlMessage.CC.Add(new MailAddress(destinatario));
                    }
                }
            }
            mySmtpClient = new SmtpClient("mail.zoluxiones.com", 2525);//80
            mySmtpClient.EnableSsl = true;
            mySmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            mySmtpClient.UseDefaultCredentials = false;
            mySmtpClient.Credentials = new NetworkCredential(de, pass);//usuario y contraseña
            mySmtpClient.Timeout = 30000;
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            mySmtpClient.Send(htmlMessage);
        }
        catch (Exception ex)
        {
            AlertaJS(ex.Message);
        }

    }

    public class Fechas
    {
        /// <summary>
        /// Funcion que permite Convetir la fecha de string a decimal
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static decimal ConvertirFechaDecimal(string fecha)
        {
            if (!string.IsNullOrEmpty(fecha))
            {
                if (fecha.Length != 10) { return 0; }
                return Convert.ToDecimal(fecha.Substring(6, 4) + fecha.Substring(3, 2) + fecha.Substring(0, 2));
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Funcion que permite Convetir la fecha de decimal a string
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ConvertirFechaString(decimal fecha)
        {
            if (fecha != 0)
            {
                return fecha.ToString().Substring(6, 2) + "/" + fecha.ToString().Substring(4, 2) + "/" + fecha.ToString().Substring(0, 4);

            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Funcion que permite obtener la hora en formato HH:mm:ss
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ObtenerHora(DateTime fecha)
        {
            return string.Format("HH:mm:ss", Convert.ToString(fecha));
        }

        /// <summary>
        /// Funcion que permite obtener la fecha actual en formato dd/mm/aaaa
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ConvertirDateToString(DateTime Fecha)
        {
            string dia = string.Empty;
            string mes = string.Empty;
            string anio = string.Empty;
            string fecha = string.Empty;
            dia = Fecha.Day.ToString("00");
            mes = Fecha.Month.ToString("00");
            anio = Fecha.Year.ToString("0");
            fecha = String.Format("{0}/{1}/{2}", dia, mes, anio);
            return fecha;
        }

        public static string ObtenerFechaActual()
        {
            string dia = string.Empty;
            string mes = string.Empty;
            string anio = string.Empty;
            string fecha = string.Empty;
            dia = DateTime.Today.Day.ToString("00");
            mes = DateTime.Today.Month.ToString("00");
            anio = DateTime.Today.Year.ToString("0");
            fecha = dia + "/" + mes + "/" + anio;
            return fecha;
        }

        /// <summary>
        /// Funcion que permite obtener la hora actual en formato decimal
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        /// 
        public static string ObtenerFechaAnterior()
        {
            string dia = string.Empty;
            string mes = string.Empty;
            string anio = string.Empty;
            string fecha = string.Empty;

            DateTime FechasAnterior = DateTime.Now;
            FechasAnterior = FechasAnterior.AddDays(-15);

            dia = FechasAnterior.Day.ToString("00");
            mes = FechasAnterior.Month.ToString("00");
            anio = FechasAnterior.Year.ToString("0");

            fecha = dia + "/" + mes + "/" + anio;
            return fecha;
        }

        public static string FechaAnterior(string fechainicio)
        {
            string dia = string.Empty;
            string mes = string.Empty;
            string anio = string.Empty;
            string fecha = string.Empty;

            DateTime FechasAnterior = Convert.ToDateTime(fechainicio);
            FechasAnterior = FechasAnterior.AddDays(-1);

            dia = FechasAnterior.Day.ToString("00");
            mes = FechasAnterior.Month.ToString("00");
            anio = FechasAnterior.Year.ToString("0");

            fecha = dia + "/" + mes + "/" + anio;
            return fecha;
        }

        public static decimal ObtenerHoraActual()
        {
            string hora = string.Empty;
            string minuto = string.Empty;
            string segundo = string.Empty;
            string HoraActual = string.Empty;
            hora = DateTime.Now.Hour.ToString();
            minuto = DateTime.Now.Minute.ToString();
            segundo = DateTime.Now.Second.ToString();
            HoraActual = hora + minuto + segundo;
            return Convert.ToDecimal(HoraActual);
        }

    }
}