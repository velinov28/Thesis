using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Thesis.Model
{
    class SendMailClass
    {
        private static DateTime today = DateTime.Now.Date;
        private static TimeSpan difference;
        private static int flag;

        private static string admin_email = "krasimirapetrova0@gmail.com";
        private static string admin_pass = "fitnessadmin";

        public static void SendEmail(Client c, int flag)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            MailMessage message = new MailMessage();
            message.From = new MailAddress(admin_email);
            message.To.Add(c.Email.Trim());
            if (flag >= 0)
            {
                message.Subject = "Предстоящо изтичане на месечен абонамент във фитнес зала";
                message.Body = "Здравейте, " + c.FirstName.Trim() + ",\n\n Искаме да Ви уведомим, че месечният Ви абонамент във " +
                  "фитнес зала Олимпия изтича на " + c.SubTo.ToShortDateString().Trim() + ".\n Приятен ден!";
            }
            else
            {
                message.Subject = "Изтекъл месечен абонамент във фитнес зала";
                message.Body = "Здравейте, " + c.FirstName.Trim() + ",\n\n Искаме да Ви уведомим, че месечният Ви абонамент във " +
                  "фитнес зала Олимпия изтече на " + c.SubTo.ToShortDateString().Trim() + ".\n Приятен ден!";
            }
            client.Credentials = new System.Net.NetworkCredential(admin_email, admin_pass);
            client.Port = 587;
            client.EnableSsl = true;

            client.Send(message);
        }

        public static void SendEmail(Client c)
        {
            difference = c.SubTo - today;
            flag = (int)difference.TotalDays;

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            MailMessage message = new MailMessage();
            message.From = new MailAddress(admin_email);
            message.To.Add(c.Email.Trim());
            if (flag >= 0)
            {
                message.Subject = "Предстоящо изтичане на месечен абонамент във фитнес зала";
                message.Body = "Здравейте, " + c.FirstName.Trim() + ",\n\n Искаме да Ви уведомим, че месечният Ви абонамент във " +
                  "фитнес зала Олимпия изтича на " + c.SubTo.ToShortDateString().Trim() + ".\n Приятен ден!";
            }
            else
            {
                message.Subject = "Изтекъл месечен абонамент във фитнес зала";
                message.Body = "Здравейте, " + c.FirstName.Trim() + ",\n\n Искаме да Ви уведомим, че месечният Ви абонамент във " +
                  "фитнес зала Олимпия изтече на " + c.SubTo.ToShortDateString().Trim() + ".\n Приятен ден!";
            }
            client.Credentials = new System.Net.NetworkCredential(admin_email, admin_pass);
            client.Port = 587;
            client.EnableSsl = true;

            client.Send(message);
        }

        public static string SendPassToEmail(string username)
        {
            Worker w = WorkerData.GetWorkerByUsername(username);

            if (w != null)
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                MailMessage message = new MailMessage();
                message.From = new MailAddress(admin_email);
                message.To.Add(w.Email.Trim());
                message.Subject = "Забравена парола за фитнес системата";
                message.Body = "Здравейте, \n\n Това е автоматично изпратено съобщение. Потребител с потребителско име <" + 
                    w.Username.Trim() + "> използва парола <" + w.Password.Trim() + "> .\n Приятен ден!";
                client.Credentials = new System.Net.NetworkCredential(admin_email, admin_pass);
                client.Port = 587;
                client.EnableSsl = true;

                client.Send(message);

                return w.Email;
            }
            else
                return null;
        }

        public static bool SendEmail(string _to, string _cc, string _bcc, string _subject, string _text)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                MailMessage message = new MailMessage();
                message.From = new MailAddress(admin_email);
                message.To.Add(_to);
                if (_cc != "")
                    message.CC.Add(_cc);
                if (_bcc != "")
                    message.Bcc.Add(_bcc);
                message.Subject = _subject;
                message.Body = _text;
                client.Credentials = new System.Net.NetworkCredential(admin_email, admin_pass);
                client.Port = 587;
                client.EnableSsl = true;

                client.Send(message);
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }

        public static void SendEmailToClientWithExpiringSubInRight3Days(Client c)
        {
            difference = c.SubTo - today;
            flag = (int)difference.TotalDays;
            if (flag == 3)
                SendMailClass.SendEmail(c, flag);
        }

        public static void SendEmailToClientWithExpiringSubIn3Days(Client c)
        {
            difference = c.SubTo - today;
            flag = (int)difference.TotalDays;
            if (flag >= 0 && flag <= 3)
                SendMailClass.SendEmail(c, flag);
        }

        public static void SendEmailToClientWithExpiredSub(Client c)
        {
            difference = c.SubTo - today;
            flag = (int)difference.TotalDays;
            if (flag < 0)
                SendMailClass.SendEmail(c, flag);
        }

        public static void SendEmailToClientWithExpiringSub(Client c)
        {
            difference = c.SubTo - today;
            flag = (int)difference.TotalDays;
            if (flag >= 0)
                SendMailClass.SendEmail(c, flag);
        }
    }
}
