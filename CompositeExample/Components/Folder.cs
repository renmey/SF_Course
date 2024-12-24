using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Components
{
    internal class Folder : Component
    {
        List<Component> subFolders = new List<Component>();

        public Folder(string name) : base(name) { }


        public override void Add(Component component)
        {
            subFolders.Add(component);
            Console.WriteLine($"В {this.Name} добавлено: {component.Name} ");
        }

        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} содержит:");
            foreach (Component component in subFolders)
                component.Display();
        }

        public override void Remove(Component component)
        {
            subFolders.Remove(component);
            Console.WriteLine($"Из {this.Name} удалено: {component.Name} ");
        }
    }
}
