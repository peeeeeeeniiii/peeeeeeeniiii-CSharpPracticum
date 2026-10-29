using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{    public class Task05_MultiplicationTable : TaskBase
    {
        public override string Title { get { return "5. Таблица умножения 10×10"; } }
        public override void Run()
        {
            for (int row = 1; row <= 10; row++)
            {
                for (int column = 1; column <= 10; column++)
                    Console.Write("{0,4}", row * column);
                Console.WriteLine();
            }
        }
    }
}
