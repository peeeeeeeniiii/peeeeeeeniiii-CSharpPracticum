
using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task01_HelloWorld : ITask
    {
        public string Title
        {
            get { return "Hello, World + текущая дата"; }
        }

        public string Description
        {
            get
            {
                return "Вывести приветствие и текущую дату в формате dd.MM.yyyy.";
            }
        }

        public string[] Requirements
        {
            get
            {
                return new string[]
                {
                    "Использовать Console.WriteLine.",
                    "Получить дату через DateTime.Now.",
                    "Отформатировать дату как dd.MM.yyyy.",
                    "Вывести две строки."
                };
            }
        }

        public void Run()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
        }
    }
}
