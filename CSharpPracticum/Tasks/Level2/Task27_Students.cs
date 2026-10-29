using System;
using System.Collections.Generic;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class Student : IComparable<Student>
    {
        public string Name { get; private set; } public double AverageGrade { get; private set; }
        public Student(string name, double grade) { Name = name; AverageGrade = grade; }
        public int CompareTo(Student other) { return other.AverageGrade.CompareTo(AverageGrade); }
        public override string ToString() { return Name + " — " + AverageGrade; }
    }
    public class ByNameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y) { return string.Compare(x.Name, y.Name, StringComparison.Ordinal); }
    }
    public class Task27_Students : TaskBase
    {
        public override string Title { get { return "27. IComparable и IComparer"; } }
        public override void Run()
        {
            List<Student> students = new List<Student> { new Student("Иван", 4.5), new Student("Анна", 5.0), new Student("Олег", 3.8), new Student("Мария", 4.7) };
            students.Sort(); Console.WriteLine("По оценке:");
            foreach (Student s in students) Console.WriteLine(s);
            students.Sort(new ByNameComparer()); Console.WriteLine("По имени:");
            foreach (Student s in students) Console.WriteLine(s);
        }
    }
}
