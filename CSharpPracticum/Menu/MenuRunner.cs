using System;
using System.Collections.Generic;
using CSharpPracticum.Common;
using CSharpPracticum.Tasks.Level1;
using CSharpPracticum.Tasks.Level2;

namespace CSharpPracticum.Menu
{
    public class MenuRunner
    {
        private readonly LevelMenu _menu = new LevelMenu();
        private readonly List<ITask> _level1 = new List<ITask>
        {
            new Task01_HelloWorld(), new Task02_PrimitiveTypes(), new Task03_Calculator(),
            new Task04_EvenNumber(), new Task05_MultiplicationTable(), new Task06_DigitSum(),
            new Task07_ReverseString(), new Task08_FizzBuzz(), new Task09_ArrayStatistics(),
            new Task10_Sorting(), new Task11_DiagonalSum(), new Task12_Palindrome(),
            new Task13_WordFrequency(), new Task14_AgeCalculator()
        };
        private readonly List<ITask> _level2 = new List<ITask>
        {
            new Task16_StringExtensions(), new Task17_StringBuilderBenchmark(), new Task18_ParseComparison(),
            new Task19_StackQueueDemo(), new Task20_GenericMethods(), new Task21_DaysEnum(),
            new Task22_ParamsSum(), new Task23_NullableValues(), new Task24_Animals(),
            new Task25_Shapes(), new Task26_Discounts(), new Task27_Students(),
            new Task28_Points(), new Task29_Notifications(), new Task30_BankAccount(),
            new Task31_FileWriter(), new Task32_Temperature(), new Task33_EmployeeQueries(),
            new Task34_WordGroups()
        };

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Практикум по C# ===");
                Console.WriteLine("1. Уровень 1 — Базовый (1–15)");
                Console.WriteLine("2. Уровень 2 — Средний (16–35)");
                Console.WriteLine("3. Уровень 3 — Продвинутый (36–50)");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите пункт: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1": _menu.Show("Уровень 1 — Базовый", _level1); break;
                    case "2": _menu.Show("Уровень 2 — Средний", _level2); break;
                    case "3":
                        Console.WriteLine("Не сделал");
                        Console.WriteLine("Нажмите Enter...");
                        Console.ReadLine();
                        break;
                    case "4": return;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите Enter.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
