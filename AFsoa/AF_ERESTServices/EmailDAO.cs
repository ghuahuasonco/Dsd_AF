using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceModel.Web;
using System.Web;

namespace AF_ERESTServices
{
    public class EmailDAO
    {
        public Email Enviar(Email EnviarEmail) {
            Email Emailenviado = null;
            /*
            try
            {
                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.EnableSsl = true;
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential("ghuahuasonco@gmail.com", "Kross986280383Kross");
                MailMessage msg = new MailMessage();
                msg.To.Add(EnviarEmail.msgto);
                msg.From = new MailAddress("ghuahuasonco@gmail.com");
                msg.Subject = EnviarEmail.msgsubjet;
                msg.Body = EnviarEmail.msgbody;
                msg.IsBodyHtml = true;
                cliente.Send(msg);
                return Emailenviado;
            }
            catch (Exception e) {
                throw new WebFaultException(System.Net.HttpStatusCode.NotAcceptable);
            }
             */

            try {
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                var mail = new MailMessage();
                mail.From = new MailAddress("ghuahuasonco@hotmail.com");
                mail.To.Add(EnviarEmail.msgto);
                mail.Subject = EnviarEmail.msgsubjet;
                mail.IsBodyHtml = true;
                mail.Body = EnviarEmail.msgbody;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ghuahuasonco@hotmail.com", "Bella986280383");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return Emailenviado;
            }
            catch (Exception e) { 
                throw new WebFaultException(System.Net.HttpStatusCode.NotAcceptable);
            }
        }
    }
}