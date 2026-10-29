using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class Task18_ParseComparison : TaskBase
    {
        public override string Title { get { return "18. TryParse и try/catch"; } }
        public override void Run()
        {
            TestTryParse("123"); TestTryParse("abc"); TestParse("123"); TestParse("abc");
        }
        private static void TestTryParse(string text)
        {
            int number; bool success = int.TryParse(text, out number);
            Console.WriteLine("TryParse(\"" + text + "\"): " + (success ? number.ToString() : "ошибка ввода"));
        }
        private static void TestParse(string text)
        {
            try { Console.WriteLine("Parse(\"" + text + "\"): " + int.Parse(text)); }
            catch (FormatException) { Console.WriteLine("Parse(\"" + text + "\"): FormatException"); }
        }
    }
}
