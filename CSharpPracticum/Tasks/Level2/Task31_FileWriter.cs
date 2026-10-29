using System;
using System.IO;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class FileWriter : IDisposable
    {
        private readonly StreamWriter _writer;
        public FileWriter(string path) { _writer = new StreamWriter(path, false); }
        public void WriteLine(string text) { _writer.WriteLine(text); }
        public void Dispose() { _writer.Dispose(); }
    }
    public class Task31_FileWriter : TaskBase
    {
        public override string Title { get { return "31. IDisposable и using"; } }
        public override void Run()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "task31-output.txt");
            using (FileWriter writer = new FileWriter(path))
            {
                writer.WriteLine("Первая строка");
                writer.WriteLine("Вторая строка");
            }
            Console.WriteLine("Файл записан: " + path);
        }
    }
}
