using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace PlataformaRPHD.Web.Services
{
    public class MailService
    {
        private string mail;
        private string mailPassword;
        private string smtpServer;
d        private string port;
        private MailMessage mailMessage;

        public MailService()
        {
            mail = ConfigurationManager.AppSettings["Mail"];
            mailPassword = ConfigurationManager.AppSettings["MailPassword"];
            smtpServer = ConfigurationManager.AppSettings["MailSMTPServer"];
            port = ConfigurationManager.AppSettings["MailPort"];
        }

        public void CreateMail(string subject, string body)
        {
            mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(mail);
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            mailMessage.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
        }

        public void AddMail(MailAddress mailAdress)
        {
            this.mailMessage.To.Add(mailAdress);
        }

        public bool Send()
        {
            try {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = smtpServer;
                smtpClient.Port = Convert.ToInt16(port);
                NetworkCredential authinfo = new NetworkCredential(mail, mailPassword);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = authinfo;
                smtpClient.Send(mailMessage);
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }
    }
}