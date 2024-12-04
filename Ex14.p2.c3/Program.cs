using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.p2.c3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
{
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var youngStudentApplications = students.Where(student => student.Age < 27).
                Select(student => new Application
                {
                    Name = student.Name,
                    YearOfBirth = DateTime.Now.Year - student.Age
                });

            foreach (var studApplication in youngStudentApplications)
                Console.WriteLine(studApplication.Name + ", " + studApplication.YearOfBirth);



            Console.ReadKey();  
        }

    }
}
