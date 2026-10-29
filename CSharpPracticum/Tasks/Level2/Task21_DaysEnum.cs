using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    public static class WeekDayHelper
    {
        public static bool IsWeekend(WeekDay day) { return day == WeekDay.Saturday || day == WeekDay.Sunday; }
        public static string GetRussianName(WeekDay day)
        {
            string[] names = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            return names[(int)day];
        }
    }
    public class Task21_DaysEnum : TaskBase
    {
        public override string Title { get { return "21. Enum: дни недели"; } }
        public override void Run()
        {
            foreach (WeekDay day in Enum.GetValues(typeof(WeekDay)))
                Console.WriteLine(WeekDayHelper.GetRussianName(day) + " — " + (WeekDayHelper.IsWeekend(day) ? "выходной" : "рабочий"));
        }
    }
}
