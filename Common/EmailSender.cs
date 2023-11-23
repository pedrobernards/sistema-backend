
using System.Net;
using System.Net.Mail;

namespace ProgramacaoZero.Api.Common
{
    public class EmailSender
    {
        public void Enviar(string assunto, string corpo, string emailDestino)
        {
            var fromEmail = "contato@renatogava.com.br";
            var fromPassword = "5yoJ8x21JAw%";
            var fromHost = "smtp.zoho.com";
            var fromPort = 587;

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(fromEmail);

            mail.To.Add(new MailAddress(emailDestino));

            mail.Subject = assunto;

            mail.Body = corpo;

            using (SmtpClient smtp = new SmtpClient(fromHost, fromPort))
            {
                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);

                smtp.EnableSsl = true;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(mail);
            }
        }

        public void EnviarEmail(string toEmail, string assunto, string corpo)
        {
            var fromEmail = "contato@renatogava.com.br";
            var fromPassword = "5yoJ8x21JAw%";
            var fromHost = "smtp.zoho.com";
            var fromPort = 587;

            MailMessage mail = new MailMessage()
            {
                From = new MailAddress(fromEmail)
            };

            mail.To.Add(new MailAddress(toEmail));

            mail.Subject = assunto;
            mail.Body = corpo;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            using (SmtpClient smtp = new SmtpClient(fromHost, fromPort))
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mail);
            }
        }
    }
}