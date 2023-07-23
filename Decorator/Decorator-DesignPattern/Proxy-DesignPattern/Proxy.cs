using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_DesignPattern
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        public void DoAction()
        {
            if (_realSubject == null)
            { 
                _realSubject = new RealSubject();
            }
            
            _realSubject.DoAction();
        }
    }
}
