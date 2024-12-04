using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.p1.c1
{
    internal class City
    {
        public string Name { get; set; }    
        public long Population {  get; set; }

        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }
    }
}
