using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_MailSample.MailService
{
    public static class Implementation
    {
        public static IMailServiceImplementor GetImplementor()
        {
            var config = ConfigurationManager.AppSettings;

            if (config["EmailServer"] == "Gmail")
                return new GmailService();
            else if (config["EmailServer"] == "Yahoo")
                return new YahooService();

             return new CompanyMailService();
        }
    }
}
