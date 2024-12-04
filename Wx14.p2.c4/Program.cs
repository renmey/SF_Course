using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wx14.p2.c4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                            var students = new List<Student>
                {
                               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
                };



                            // Список курсов
                            var coarses = new List<Coarse>
                            {
                           new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                           new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
                };

            var studentsWithCoarses = from student in students
                                      where student.Age < 29
                                      where student.Languages.Contains("английский")
                                      let birthYear = DateTime.Now.Year - student.Age
                                      from coarse in coarses
                                      where coarse.Name.Contains("C#")
                                      select new
                                      {
                                          Name = student.Name,
                                          BirthYear = birthYear,
                                          CoarseName = coarse.Name,
                                      };

            foreach (var stud in studentsWithCoarses)
                Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) добавлен курс {stud.CoarseName}");


            Console.ReadKey();
        }
    }
}
