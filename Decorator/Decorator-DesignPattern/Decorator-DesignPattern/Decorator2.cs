using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    public abstract class Decorator2 : Component2
    {
        private readonly Component2 _component2;
        public Decorator2(Component2 component2)
        {
            _component2 = component2;
        }

        public override void Operation01()
        {
            _component2.Operation01();
        }
        public override void Operation02()
        {
            _component2.Operation02();
        }
    }

    public class ConcreteDecorator2 : Decorator2
    {
        public ConcreteDecorator2(Component2 component2):base(component2)
        {
            
        }

        public override void Operation01()
        {
            base.Operation01();
            NewMessage();
        }
        public override void Operation02()
        {
            base.Operation02();
        }

        public void NewMessage()
        {
            Console.WriteLine("New Declaration");
        }
    }
}
