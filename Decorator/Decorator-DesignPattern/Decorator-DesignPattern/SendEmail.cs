using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    public class SendEmail
    {
        public void Send()
        {
            Console.WriteLine("Email hase been sended ... ");

        }
    }

    public class SendEmaiDecorator : SendEmail
    {
        private readonly SendEmail _sendEmail;
        public SendEmaiDecorator(SendEmail sendEmail)
        {
            _sendEmail = sendEmail;            
        }

        public void Send()
        {
            _sendEmail.Send();
            SaveLog();
        }

        private void SaveLog()
        { Console.WriteLine("Log has been Saved ... "); }
    }
}
