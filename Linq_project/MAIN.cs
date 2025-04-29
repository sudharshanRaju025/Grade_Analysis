using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_project
{
    class MAIN
    {

        class Student
        {
            public int Id;
            public string Name="";
            public int Score;
        }

        public static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student { Id = 1,Name="sudha",Score=98 },
                new Student { Id = 2,Name="sinchan",Score=97 },
                new Student { Id = 3,Name="mahendra",Score=87 },
                new Student { Id = 4,Name="lakashmi",Score=79 },
                new Student { Id = 5,Name="keerthi",Score=89 },
            };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            double average = students.Average(s=>s.Score);

            var Highest = students.Max(s => s.Score);

            var Lowest = students.Min(s => s.Score);

            var below_average = students.Where(s => s.Score < average);

            var below_average_students = students.Where(s => s.Score < average).Select(s=>s.Name);

            var above_average_students = students.Where(s => s.Score > average).Select(s=>s.Name);

            var order = students.OrderBy(j => j.Name);

           

            Console.WriteLine("enter the operation:");
            string Filters = Console.ReadLine()!;

            string filter = Filters.ToLower();
            if (filter == "average")
            {
                Console.WriteLine("the average marks of the students:" + average);
            }
            else if (filter == "highest")
            {
                Console.WriteLine("the highest marks in the students:" + Highest);

            }
            else if (filter =="lowest")
            {
                Console.WriteLine("the lowesst marks in the students:"+Lowest);
            }
            else if (filter=="below_average")
            {
                Console.WriteLine("the below average score is:"+below_average);
            }
            else if (filter == "order")
            {
                Console.WriteLine("the alphabetical order of the stdent names:" + order);
            }
            else if (filter == "above_average")
            {
                Console.WriteLine("the above average students namwes:" + above_average_students);
            }
            else
            {
                Console.WriteLine("sorry there is nothing like the filter you entered");
            }
           


        }
    }
}

