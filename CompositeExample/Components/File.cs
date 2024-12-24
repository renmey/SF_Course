using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Components
{
    internal class File : Component
    {
        public File(string name) : base(name) { }


        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
