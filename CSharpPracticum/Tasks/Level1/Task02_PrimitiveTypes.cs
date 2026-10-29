using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task02_PrimitiveTypes : TaskBase
    {
        public override string Title { get { return "2. Примитивные типы"; } }
        public override void Run()
        {
            int age = 18; long population = 8000000000L; double height = 1.81;
            float temperature = 36.6f; decimal price = 12.50m; bool isStudent = true;
            char letter = 'A'; string name = "Alex";
            Show("age", age); Show("population", population); Show("height", height);
            Show("temperature", temperature); Show("price", price); Show("isStudent", isStudent);
            Show("letter", letter); Show("name", name);
        }
        private static void Show(string name, object value)
        {
            Console.WriteLine(name + " = " + value + " (" + value.GetType().Name + ")");
        }
    }
}
