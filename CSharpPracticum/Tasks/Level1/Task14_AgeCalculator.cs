using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task14_AgeCalculator : TaskBase
    {
        public override string Title { get { return "14. Возраст по дате рождения"; } }
        public override void Run()
        {
            Console.Write("Дата рождения (дд.мм.гггг): ");
            DateTime birth;
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null,
                System.Globalization.DateTimeStyles.None, out birth) || birth.Date > DateTime.Today)
            { Console.WriteLine("Некорректная дата."); return; }
            DateTime today = DateTime.Today;
            int years = today.Year - birth.Year;
            if (birth.Date > today.AddYears(-years)) years--;
            int months = (today.Year - birth.Year) * 12 + today.Month - birth.Month;
            if (today.Day < birth.Day) months--;
            int days = (today - birth).Days;
            Console.WriteLine("Полных лет: " + years);
            Console.WriteLine("Полных месяцев всего: " + months);
            Console.WriteLine("Дней всего: " + days);
        }
    }
}
