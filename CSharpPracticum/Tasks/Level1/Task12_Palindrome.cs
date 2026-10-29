using System;
using System.Text;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task12_Palindrome : TaskBase
    {
        public override string Title { get { return "12. Палиндром"; } }
        public override void Run()
        {
            string text = ReadText("Введите строку: ");
            StringBuilder cleaned = new StringBuilder();
            foreach (char c in text.ToLowerInvariant())
                if (char.IsLetterOrDigit(c)) cleaned.Append(c);
            bool result = true;
            for (int i = 0; i < cleaned.Length / 2; i++)
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i]) { result = false; break; }
            Console.WriteLine(result ? "Это палиндром." : "Это не палиндром.");
        }
    }
}
