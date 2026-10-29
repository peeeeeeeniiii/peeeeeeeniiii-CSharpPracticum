using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task03_Calculator : TaskBase
    {
        public override string Title { get { return "3. Калькулятор"; } }
        public override void Run()
        {
            double a, b;
            Console.Write("Первое число: ");
            if (!double.TryParse(Console.ReadLine(), out a)) { Console.WriteLine("Некорректное число."); return; }
            Console.Write("Операция (+, -, *, /): "); string op = Console.ReadLine();
            Console.Write("Второе число: ");
            if (!double.TryParse(Console.ReadLine(), out b)) { Console.WriteLine("Некорректное число."); return; }
            switch (op)
            {
                case "+": Console.WriteLine(a + b); break;
                case "-": Console.WriteLine(a - b); break;
                case "*": Console.WriteLine(a * b); break;
                case "/": if (b == 0) Console.WriteLine("На ноль делить нельзя."); else Console.WriteLine(a / b); break;
                default: Console.WriteLine("Неизвестная операция."); break;
            }
        }
    }
}
