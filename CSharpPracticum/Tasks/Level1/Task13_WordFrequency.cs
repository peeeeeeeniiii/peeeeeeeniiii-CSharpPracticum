using System;
using System.Collections.Generic;
using System.Linq;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task13_WordFrequency : TaskBase
    {
        public override string Title { get { return "13. Частота слов"; } }
        public override void Run()
        {
            string text = ReadText("Введите текст: ").ToLowerInvariant();
            char[] separators = " .,!?;:-()[]{}\"'\t\r\n".ToCharArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in text.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                if (counts.ContainsKey(word)) counts[word]++;
                else counts[word] = 1;
            }
            foreach (var item in counts.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
