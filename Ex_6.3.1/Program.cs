using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6._3._1
{



    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            var department = GetCurrentDepartment();

            if(department?.Company?.Type =="Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }


            Console.ReadKey();


        }

        static Department GetCurrentDepartment()
        {
            Department department = new Department();
            
            return department;

        }
    }
}
