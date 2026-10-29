using System;
using System.Text;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string value)
        {
            string s = ""; foreach (char c in value.ToLowerInvariant()) if (char.IsLetterOrDigit(c)) s += c;
            for (int i = 0; i < s.Length / 2; i++) if (s[i] != s[s.Length - 1 - i]) return false;
            return true;
        }
        public static int WordCount(this string value)
        {
            return value.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static string ReverseString(this string value)
        {
            StringBuilder result = new StringBuilder();
            for (int i = value.Length - 1; i >= 0; i--) result.Append(value[i]);
            return result.ToString();
        }
    }
    public class Task16_StringExtensions : TaskBase
    {
        public override string Title { get { return "16. Методы расширения строк"; } }
        public override void Run()
        {
            string[] examples = { "level", "Hello C Sharp", "А роза упала на лапу Азора" };
            foreach (string s in examples)
                Console.WriteLine("\"" + s + "\" | палиндром: " + s.IsPalindrome() + " | слов: " + s.WordCount() + " | наоборот: " + s.ReverseString());
        }
    }
}
