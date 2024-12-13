using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.p2.c3
{

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>
                {
                new Student {Name="Андрей", Age=23 },
                new Student {Name="Сергей", Age=27 },
                new Student {Name="Дмитрий", Age=29 }
                };

            Console.WriteLine(Average(students  ));

            Console.ReadKey();


        }

        static double Average(List<Student> students)
        {
            var average = students.Sum(student => student.Age)/students.Count();
            return average;
        }

    }
}
