using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    public class WebClientDecorator
    {
        private readonly WebClient _webClient;
        public WebClientDecorator(WebClient webClient)
        {
            _webClient = webClient;
        }

        public string DownloadString(string address)
        {
            if (!string.IsNullOrEmpty(address) && address.StartsWith("https://my.bmi.ir/portalserver/app/index.html")) 
            {
                return _webClient.DownloadString(address);
            }

            return "No Address Imported";
        }
    }
}
