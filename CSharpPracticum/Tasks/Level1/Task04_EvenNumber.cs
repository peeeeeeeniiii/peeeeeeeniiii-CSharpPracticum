using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task04_EvenNumber : TaskBase
    {
        public override string Title { get { return "4. Проверка чётности"; } }
        public override void Run()
        {
            int number = ReadInt("Введите целое число: ", 0);
            Console.WriteLine("Через метод: " + IsEven(number));
            Console.WriteLine("Через тернарный оператор: " + (number % 2 == 0 ? "чётное" : "нечётное"));
        }
        private static string IsEven(int number) { return number % 2 == 0 ? "чётное" : "нечётное"; }
    }
}
