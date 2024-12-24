using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Components
{
    abstract class Component
    {
        public readonly string Name;

        protected Component(string Name)
        {
            this.Name = Name;
        }

        #region Методы для добавления / удаления подкомпонентов
        public abstract void Display();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);

        #endregion
    }
}
