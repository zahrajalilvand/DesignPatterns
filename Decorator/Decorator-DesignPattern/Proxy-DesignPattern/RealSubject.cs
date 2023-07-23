﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_DesignPattern
{
    public class RealSubject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("The method is running ... ");
        }
    }
}
