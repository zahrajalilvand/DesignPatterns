using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignPattern
{
    public class Composite:Component
    {
        private List<Component> _component = new List<Component>();
        public Composite(string name):base(name)
        {
        }

        public Composite(string name, Component[] compoents):base(name)
        {
            foreach (var item in compoents)
            {
                Add(item);
            }
        }

        public override void Add(Component component)
        {
            _component.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth), name);
            foreach (var item in _component)
            {
                item.Display(depth+2);
            }
        }

        public override void Remove(Component component)
        {
            _component.Remove(component);
        }
    }
}
