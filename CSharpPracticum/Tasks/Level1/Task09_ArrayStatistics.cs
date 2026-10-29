using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task09_ArrayStatistics : TaskBase
    {
        public override string Title { get { return "9. Статистика массива"; } }
        public override void Run()
        {
            int[] values = { 7, -2, 15, 4, 0, 11 };
            Console.WriteLine("Массив: " + string.Join(", ", values));
            Console.WriteLine("Минимум: " + FindMin(values));
            Console.WriteLine("Максимум: " + FindMax(values));
            Console.WriteLine("Сумма: " + Sum(values));
            Console.WriteLine("Среднее: " + Average(values));
        }
        private static int FindMin(int[] a) { if (a.Length == 0) throw new InvalidOperationException("Пустой массив."); int r = a[0]; foreach (int x in a) if (x < r) r = x; return r; }
        private static int FindMax(int[] a) { if (a.Length == 0) throw new InvalidOperationException("Пустой массив."); int r = a[0]; foreach (int x in a) if (x > r) r = x; return r; }
        private static int Sum(int[] a) { int r = 0; foreach (int x in a) r += x; return r; }
        private static double Average(int[] a) { if (a.Length == 0) return 0; return (double)Sum(a) / a.Length; }
    }
}
