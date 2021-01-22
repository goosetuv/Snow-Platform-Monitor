#region Dependencies
using SnowPlatformMonitor.Core.Configuration;
using System;
using System.IO;
using System.Net.Mail;
#endregion

namespace SnowPlatformMonitor.Core.Classes
{
    public class Mailer
    {
        #region Fields
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();

        private string subject;
        private string sender;
        private string displayname;
        private string host;
        private string port;
        private string user;
        private string pass;
        private bool sslEnabled;
        private string to;
        private string cc;
        private string body;
        #endregion

        public void OnLoad()
        {
            if (!File.Exists(dc.Resources + "email.html"))
            {
                File.WriteAllText(dc.Resources + "email.html", Properties.Resources.email);
            }
        }

        public void SendTestEmail(string version)
        {
            string testAttachment = dc.Export + "test.txt";

            user = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Username");
            pass = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Password"));
            port = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Port");
            sslEnabled = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SSLEnabled"));
            host = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Host");
            sender = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Sender");
            if (Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SenderName").Length < 1)
            {
                displayname = sender;
            }
            else
            {
                displayname = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SenderName");
            }
            to = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SendTo");
            cc = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "CC");

            body = File.ReadAllText(dc.Resources + "email.html").Replace("{year}", DateTime.Now.Year.ToString()).Replace("{version}", version);

            if (!File.Exists(testAttachment))
            {
                File.WriteAllText(testAttachment, "This is a test attachment");
            }

            Emailer(testAttachment, "Test Email - Snow Platform Monitor");
            File.Delete(testAttachment);
        }

        public void SendEmail(string attachment, string version)
        {
            user = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Username");
            pass = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Password"));
            port = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Port");
            sslEnabled = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SSLEnabled"));
            host = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Host");
            sender = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Sender");
            if(Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SenderName").Length < 1)
            {
                displayname = sender;
            } else
            {
                displayname = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SenderName");
            }
            to = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SendTo");
            cc = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "CC");
            subject = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Subject");

            body = File.ReadAllText(dc.Resources + "email.html")
                .Replace("{year}", DateTime.Now.Year.ToString())
                .Replace("{version}", version)
                .Replace("{datetime}", DateTime.Now.ToString("d-MMMM-yyyy HH:mm:ss"));

            Emailer(attachment, subject);
            File.Delete(attachment);
        }


        internal void Emailer(string filePath, string emailSubject = "Report - Snow Platform Monitor")
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress(sender, displayname),
                IsBodyHtml = true,
                Subject = emailSubject,
                Body = body,
                Priority = MailPriority.Normal // for ... future stuff 
            };

            SmtpClient smtp = new SmtpClient(host)
            {
                Port = Convert.ToInt32(port),
                Credentials = new System.Net.NetworkCredential(user, pass),
                EnableSsl = sslEnabled
            };

            Attachment att = new Attachment(filePath);

            mail.Attachments.Add(att);
            mail.To.Add(to);

            if (cc.Length > 0)
            {
                mail.CC.Add(cc);
            }

            smtp.Send(mail);
            smtp.Dispose();
            mail.Dispose();
        }
    }
}
