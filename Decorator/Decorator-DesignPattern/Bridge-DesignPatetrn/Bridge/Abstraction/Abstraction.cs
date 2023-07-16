using Bridge_DesignPatetrn.Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPatetrn.Bridge.Abstraction
{
    public abstract class Abstraction
    {
        private Implement implement;
        public Abstraction()
        {
            implement = new ConcreteImplement();
        }

        public virtual void Function()
        {
            implement.Implementation();
        }
    }
}
