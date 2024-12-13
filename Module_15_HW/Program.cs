﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_15_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

            Console.ReadKey();

        }



        static string[] GetAllStudents(Classroom[] classes)
        {
            var students = from classroom in classes
                           from student in classroom.Students
                           select student;

            return students.ToArray();
        }

    }
}

