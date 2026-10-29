using System;
using System.Linq;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class Task34_WordGroups : TaskBase
    {
        public override string Title { get { return "34. Группировка слов"; } }
        public override void Run()
        {
            string[] words = { "арбуз", "апельсин", "банан", "брусника", "вишня", "виноград", "груша", "дыня", "дом", "ёж", "яблоко", "ягода" };
            foreach (var group in words.GroupBy(x => char.ToUpperInvariant(x[0])).OrderBy(x => x.Key))
            {
                Console.WriteLine(group.Key + ": " + string.Join(", ", group.OrderBy(x => x)));
            }
        }
    }
}
