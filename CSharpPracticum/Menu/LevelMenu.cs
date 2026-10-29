using System;
using System.Collections.Generic;
using CSharpPracticum.Common;

namespace CSharpPracticum.Menu
{
    public class LevelMenu
    {
        public void Show(string title, List<ITask> tasks)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- " + title + " ---");
                for (int i = 0; i < tasks.Count; i++)
                    Console.WriteLine((i + 1) + ". " + tasks[i].Title);
                Console.WriteLine("0. Назад");
                Console.Write("Выберите задание: ");
                string input = Console.ReadLine();
                if (input == "0") return;

                int choice;
                if (int.TryParse(input, out choice) && choice >= 1 && choice <= tasks.Count)
                {
                    ITask task = tasks[choice - 1];
                    Console.Clear();
                    Console.WriteLine(task.Title);
                    Console.WriteLine(task.Description);
                    Console.WriteLine("\nТребования:");
                    foreach (string requirement in task.Requirements)
                        Console.WriteLine("- " + requirement);
                    Console.WriteLine();
                    try { task.Run(); }
                    catch (Exception ex) { Console.WriteLine("Ошибка выполнения: " + ex.Message); }
                    Console.WriteLine("\nНажмите Enter для возврата в меню...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Некорректный выбор. Нажмите Enter.");
                    Console.ReadLine();
                }
            }
        }
    }
}
