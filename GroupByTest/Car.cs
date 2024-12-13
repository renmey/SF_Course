using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByTest
{
    internal class Car
    {
        public string Manufacturer { get; set; }
        public string CountryCode { get; set; }

        public Car(string Manufacturer, string CountryCode)
        {
        this.Manufacturer = Manufacturer;
            this.CountryCode = CountryCode;
        
        }

    }
}
