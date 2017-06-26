using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace INNBAHI.Helpers
{
    public static class Email
    {
        public static void Send(string to, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(new MailAddress(to));
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient client = new SmtpClient();
                client.Send(mail);
            }
            catch(Exception ex)
            {
                Logger.Instance.Error(ex, "Error sending email in {Class}/{Method}", "Email", "Send");

                throw;
            }
        }
    }
}