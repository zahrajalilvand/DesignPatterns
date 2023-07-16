using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPatetrn.Bridge.Implementation
{
    internal class ConcreteImplement : Implement
    {
        public override void Implementation()
        {
            Console.WriteLine("Run ConcreteImplement.Implementation() ... !");
        }
    }
}
