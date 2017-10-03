using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace PlataformaRPHD.Web.ViewModels
{
    public class MailService
    {
        private string mail;
        private string mailPassword;
        private string smtpServer;
        private string port;
        private MailMessage mailMessage;

        public MailService()
        {
            mail = ConfigurationManager.AppSettings["Mail"];
            mailPassword = ConfigurationManager.AppSettings["MailPassword"];
            smtpServer = ConfigurationManager.AppSettings["MailSMTPServer"];
            port = ConfigurationManager.AppSettings["MailPort"];
        }

        public void CreateMail(List<string> to, string subject, string body)
        {
            mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(mail);
            foreach(var item in to)
            {
                mailMessage.To.Add(item);
            }
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            mailMessage.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
        }

        public void Send()
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = mail;
            smtpClient.Port = Convert.ToInt16(port);
            smtpClient.Credentials = new NetworkCredential(mail, mailPassword);
            smtpClient.Send(mailMessage);
        }
    }
}