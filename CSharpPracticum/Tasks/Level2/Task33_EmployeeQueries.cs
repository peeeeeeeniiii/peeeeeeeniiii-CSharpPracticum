using System;
using System.Collections.Generic;
using System.Linq;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class Employee
    {
        public string Name { get; set; } public int Age { get; set; } public decimal Salary { get; set; } public string Department { get; set; }
    }
    public class Task33_EmployeeQueries : TaskBase
    {
        public override string Title { get { return "33. LINQ по сотрудникам"; } }
        public override void Run()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name="Анна", Age=25, Salary=70000, Department="IT" },
                new Employee { Name="Борис", Age=41, Salary=95000, Department="IT" },
                new Employee { Name="Вера", Age=35, Salary=80000, Department="HR" },
                new Employee { Name="Глеб", Age=29, Salary=60000, Department="HR" },
                new Employee { Name="Дина", Age=44, Salary=110000, Department="IT" },
                new Employee { Name="Егор", Age=32, Salary=75000, Department="Sales" },
                new Employee { Name="Жанна", Age=38, Salary=90000, Department="Sales" },
                new Employee { Name="Илья", Age=22, Salary=50000, Department="IT" },
                new Employee { Name="Кира", Age=31, Salary=72000, Department="HR" },
                new Employee { Name="Лев", Age=50, Salary=120000, Department="Sales" }
            };
            Console.WriteLine("Топ-3 зарплат:");
            foreach (Employee e in employees.OrderByDescending(x => x.Salary).Take(3)) Console.WriteLine(e.Name + ": " + e.Salary);
            Console.WriteLine("Средняя зарплата по отделам:");
            foreach (var group in employees.GroupBy(x => x.Department)) Console.WriteLine(group.Key + ": " + group.Average(x => x.Salary).ToString("F2"));
            Console.WriteLine("Старше 30:");
            foreach (Employee e in employees.Where(x => x.Age > 30)) Console.WriteLine(e.Name + ", " + e.Age);
        }
    }
}
