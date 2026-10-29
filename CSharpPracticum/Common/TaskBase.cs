using System;

namespace CSharpPracticum.Common
{
    public abstract class TaskBase : ITask
    {
        public abstract string Title { get; }
        public virtual string Description { get { return Title; } }
        public virtual string[] Requirements { get { return new string[] { "Выполнить задание и вывести результат." }; } }
        public abstract void Run();

        protected static int ReadInt(string prompt, int defaultValue)
        {
            Console.Write(prompt);
            int value;
            return int.TryParse(Console.ReadLine(), out value) ? value : defaultValue;
        }

        protected static string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? "";
        }
    }
}
