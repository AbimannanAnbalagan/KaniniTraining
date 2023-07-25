using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ExamplesForClassification
    {
        public void Example1() 
        {
            List<string> courses = new List<string>();
            courses.Add("C# tutorial");
            courses.Add("MySQL");
            courses.Add("Python tutorial");
            courses.Add("MangoDB");
            courses.Add("Java tutorial");

            var tutcourses = from c in courses where c.Contains("tutorial") || c.Contains("MySQL") select c;
            foreach (var tut in tutcourses)
            {
                Console.WriteLine(tut);
            }

            var tutcourse1 = courses.Where(c => c.Contains("tutorial") && c.Contains("C#"));
            foreach (var tut in tutcourse1)
            {
                Console.WriteLine(tut);
            }
        }

        public void Example2()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "BBB",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 15 }
            };


        }

        public void Example3()
        {
            IList elements = new ArrayList();
            elements.Add(12);
            elements.Add(13.5);
            elements.Add("ABC");
            elements.Add('D');
            elements.Add(25);
            elements.Add("EFG");

            var strings = from e in elements.OfType<string>() select e;
            var  numbers = from e in elements.OfType<int>() select e;

            foreach (var e in strings)
            {
                Console.WriteLine(e);
            }
            foreach (var e in numbers)
            {
                Console.WriteLine(e);
            }

            var strings1 = elements.OfType<string>();
        }

        public void Sorting_OrderBy()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "ZZZ",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 15 }, 
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 13 }
            };

            var result = from student in studentList orderby student.StudentName descending select student;

            foreach (var stud in result)
            {
                Console.WriteLine(stud.StudentName);
            }
            Console.WriteLine();
            var result1 = studentList.OrderByDescending(s=> s.Age); 
            foreach (var stud in result1)
            {
                Console.WriteLine(stud.StudentName +"  "+stud.Age);
            }
            Console.WriteLine();
            var result2 = studentList.OrderBy(s=> s.Age).ThenByDescending(s=>s.StudentName) ;
            foreach (var stud in result2)
            {
                Console.WriteLine(stud.StudentName + "  " + stud.Age);
            }
            Console.WriteLine();
        }

        public void GroupBy()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "ZZZ",  Age = 18 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 15 },
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 13 }
            };

            var result = from s in studentList group s by s.Age;

            foreach (var s in result) 
            {
                Console.WriteLine(s.Key);
                
                foreach (var stud in s) 
                {
                    Console.WriteLine($"Age = {stud.Age} Name = {stud.StudentName}");
                }
                Console.WriteLine();
            }
        }

        public void lookup()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "ZZZ",  Age = 18 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 15 } ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 13 }

            };
        }
    }
}
