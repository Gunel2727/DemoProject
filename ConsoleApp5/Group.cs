using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Group
    {
        private static int _no  = 100;
        public string No { get; }
        private Student[] _students = new Student[0];
        public Group()
        {
            _no++;
            No=$"AP{_no}";
            
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public Student[] GetAllStudents()
        {
            return _students;
        }
        public Student[] Sort()
        {
            Student[] sortedStudents = new Student[_students.Length];
            Array.Copy(_students, sortedStudents, _students.Length);
            Array.Sort(sortedStudents, (s1, s2) => s2.Point.CompareTo(s1.Point));
            return sortedStudents;

        }


    }
}
