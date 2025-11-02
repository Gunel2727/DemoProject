using DemoProject;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1= new Student("John", "Doe", 20, 85.5);
            Student student2= new Student("Jane", "Smith", 22, 90.0);
            Student student3= new Student("Alice", "Johnson", 19, 78.0);
            Student student4= new Student("Bob", "Brown", 21, 88.5);
            Group group= new Group();
            group.AddStudent(student1);
            group.AddStudent(student2); 
            group.AddStudent(student3);
            group.AddStudent(student4);
            foreach (var student in group.GetAllStudents())
            {
                student.ShowInfo();
            }
            Console.WriteLine("Sorted Students by Point:");
            foreach (var student in group.Sort())
            {
                student.ShowInfo();
            }
            Group group2= new Group();
            Console.WriteLine(group2.No);
            
        }
    }
}
