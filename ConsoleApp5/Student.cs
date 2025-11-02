using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Student
    {
        private static int _id { get; set; } = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }
        


        public Student(string name, string surName, int age, double point)
        {
            Name = name;
            SurName = surName;
            Age = age;
            Point = point;
            _id++;
            Id = _id;



        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id},Name: {Name}, SurName: {SurName}, Age: {Age}, Point: {Point}");
        }
        public static bool operator > (Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }
        public static bool operator < (Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }

    }
}

