using System;
using System.Diagnostics;
using System.Text;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class Task17_StringBuilderBenchmark : TaskBase
    {
        public override string Title { get { return "17. StringBuilder и конкатенация"; } }
        public override void Run()
        {
            int count = 10000;
            Stopwatch sw = Stopwatch.StartNew(); string result = "";
            for (int i = 0; i < count; i++) result += i;
            sw.Stop(); Console.WriteLine("Конкатенация: " + sw.ElapsedMilliseconds + " мс; длина " + result.Length);
            sw.Restart(); StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++) builder.Append(i);
            sw.Stop(); Console.WriteLine("StringBuilder: " + sw.ElapsedMilliseconds + " мс; длина " + builder.Length);
            Console.WriteLine("StringBuilder обычно быстрее, потому что не создаёт новую строку на каждой итерации.");
        }
    }
}
