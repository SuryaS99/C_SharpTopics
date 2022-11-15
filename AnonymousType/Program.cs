using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
            new Student(){id=01, firstName="Ankur", lastName="Varma"},
            new Student(){id=02, firstName="Divya", lastName="Patil"},
            new Student(){id=03, firstName="Nisha", lastName="Joshi"}
            };
            var Studen = from s in students
                         select new { Id = s.id, Name = s.firstName + " " + s.lastName };



            foreach (var StuInfo in students)
            {
                Console.WriteLine(StuInfo.id + " " + StuInfo.firstName + " " + StuInfo.lastName);
            }

            foreach (var item in Studen)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }
    }

    class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
