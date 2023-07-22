using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_MailSample.MailService
{
    public interface IMailServiceImplementor
    {
        void SendEmail(string Reciver, string Title, string Message);
    }

    public class GmailService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            Console.WriteLine($"Email --{Title}-- Send to --{Reciver}-- With  **{nameof(GmailService)}**");
        }
    }

    public class YahooService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            Console.WriteLine($"Email --{Title}-- Send to --{Reciver}-- With  **{nameof(YahooService)}**");
        }
    }

    public class CompanyMailService :IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            Console.WriteLine($"Email : {Title} -- Reciver : {Reciver} Message : {Message} With **{nameof(CompanyMailService)}**");
        }
    }
}
