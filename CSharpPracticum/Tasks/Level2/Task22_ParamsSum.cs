using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public static class SumHelper
    {
        public static int Sum(params int[] numbers) { int result = 0; foreach (int n in numbers) result += n; return result; }
        public static int SumArray(int[] numbers) { return Sum(numbers); }
    }
    public class Task22_ParamsSum : TaskBase
    {
        public override string Title { get { return "22. params и массив"; } }
        public override void Run()
        {
            Console.WriteLine("Sum(1, 2, 3) = " + SumHelper.Sum(1, 2, 3));
            int[] values = { 4, 5, 6 };
            Console.WriteLine("SumArray(values) = " + SumHelper.SumArray(values));
        }
    }
}
