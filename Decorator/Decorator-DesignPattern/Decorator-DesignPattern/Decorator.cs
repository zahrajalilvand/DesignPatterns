using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    public abstract class Decorator:Component
    {
        private Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
            
        }

        public override void Operation()
        { 
            base.Operation();
            NewFeature();
        }

        public void NewFeature()
        {
            Console.WriteLine("Showing New Feature .. ");
        }
    }
}
