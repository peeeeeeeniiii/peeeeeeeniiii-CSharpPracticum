using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task08_FizzBuzz : TaskBase
    {
        public override string Title { get { return "8. FizzBuzz"; } }
        public override void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
    }
}
