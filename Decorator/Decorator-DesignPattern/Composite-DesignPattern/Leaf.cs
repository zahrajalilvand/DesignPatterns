using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignPattern
{
    public class Leaf:Component
    {
        public Leaf(string name):base(name)
        {
        }

        public override void Add(Component compoent)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void Remove(Component compoent)
        {
            throw new NotImplementedException();
        }
    }
}
