using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    public abstract class Component2
    {
        public abstract void Operation01();
        public abstract void Operation02();
    }

    public class ConcereteComponent2 : Component2
    {
        public override void Operation01()
        {
            Console.WriteLine("Component02 with first method is implemented");
        }

        public override void Operation02()
        {
            Console.WriteLine("Component02 with second method is implemented");
        }
    }
}
