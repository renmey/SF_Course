using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.p1.c2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
          {
              new Student{Name = "Jaime", Age = 23, Languages = new List<string>{"english", "russian"} },
              new Student{Name = "Mary", Age = 19, Languages = new List<string>{"english", "french"} },
              new Student{Name = "Toby", Age = 24, Languages = new List<string>{"english", "japanese"} }

          };

            var names = students.Select(x => x.Name).ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            var studentsApplication = from student in students
                                      select new
                                      {
                                          FirstName = student.Name,
                                          YearOfBirth = DateTime.Now.Year - student.Age
                                      };

            foreach (var student in studentsApplication)
            {
                Console.WriteLine(student.FirstName + ", " + student.YearOfBirth);
            }


            Console.ReadKey();


        }
    }
}
