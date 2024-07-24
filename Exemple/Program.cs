using Exemple.Genercs;
using Exemple.Linq;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student { StudentId = 1, Name = "John", Grades = new List<int> { 90, 92, 80 } });
            students.Add(new Student { StudentId = 2, Name = "Jane", Grades = new List<int> { 88, 94, 90 } });
            students.Add(new Student { StudentId = 3, Name = "Sue", Grades = new List<int> { 92, 90, 96 } });
            students.Add(new Student { StudentId = 4, Name = "Joe", Grades = new List<int> { 68, 74, 82 } });
            students.Add(new Student {  StudentId = 5, Name = "Don", Grades = new List<int> { 88, 62, 70 } });
            students.Add(new Student {  StudentId = 6, Name = "Ron", Grades = new List<int> { 42, 8, 90 } });

            var eminentStudents = students.Where(s => s.Grades.Average() > 85).Select(s => new {s.Name, AverageGrade = s.Grades.Average()});
            foreach (var student in eminentStudents)
            {
                Console.WriteLine($"{student.Name} has an average grade of {student.AverageGrade}");
            }
        }
    }
}
