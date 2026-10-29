using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task07_ReverseString : TaskBase
    {
        public override string Title { get { return "7. Разворот строки"; } }
        public override void Run()
        {
            string text = ReadText("Введите строку: ");
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--) result += text[i];
            Console.WriteLine(result);
        }
    }
}
