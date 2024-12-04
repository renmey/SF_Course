using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.p2.c9
{
    internal class Car
    {
        public string Manufacturer { get; set; }
        public string CountryCode { get; set; }

        public Car(string manufacturer, string countryCode)
        {
            Manufacturer = manufacturer;
            CountryCode = countryCode;
        }
    }
}
