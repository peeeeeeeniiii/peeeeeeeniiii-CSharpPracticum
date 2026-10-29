using System;
using System.Diagnostics;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task10_Sorting : TaskBase
    {
        public override string Title { get { return "10. Сортировки"; } }
        public override void Run()
        {
            int[] source = new int[10000]; Random random = new Random();
            for (int i = 0; i < source.Length; i++) source[i] = random.Next(100000);
            int[] a = (int[])source.Clone(); int[] b = (int[])source.Clone();
            Stopwatch sw = Stopwatch.StartNew(); BubbleSort(a); sw.Stop();
            Console.WriteLine("Пузырьком: " + sw.ElapsedMilliseconds + " мс");
            sw.Restart(); InsertionSort(b); sw.Stop();
            Console.WriteLine("Вставками: " + sw.ElapsedMilliseconds + " мс");
            Console.WriteLine("Первые 10 элементов: " + string.Join(", ", FirstTen(b)));
        }
        private static int[] FirstTen(int[] a) { int n = Math.Min(10, a.Length); int[] r = new int[n]; Array.Copy(a, r, n); return r; }
        private static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = 0; j < a.Length - i - 1; j++)
                    if (a[j] > a[j + 1]) { int t = a[j]; a[j] = a[j + 1]; a[j + 1] = t; }
        }
        private static void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i], j = i - 1;
                while (j >= 0 && a[j] > key) { a[j + 1] = a[j]; j--; }
                a[j + 1] = key;
            }
        }
    }
}
