using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public static class GenericMethods
    {
        public static void Swap<T>(ref T a, ref T b) { T temp = a; a = b; b = temp; }
        public static T Max<T>(T a, T b) where T : IComparable<T> { return a.CompareTo(b) >= 0 ? a : b; }
    }
    public class Task20_GenericMethods : TaskBase
    {
        public override string Title { get { return "20. Обобщённые методы"; } }
        public override void Run()
        {
            int a = 1, b = 9; GenericMethods.Swap(ref a, ref b); Console.WriteLine("Swap int: " + a + ", " + b);
            Console.WriteLine("Max int: " + GenericMethods.Max(4, 7));
            Console.WriteLine("Max string: " + GenericMethods.Max("apple", "pear"));
            Console.WriteLine("Max double: " + GenericMethods.Max(2.5, 8.1));
        }
    }
}
