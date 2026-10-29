using System;
using System.Collections.Generic;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class SettingsStore
    {
        private readonly Dictionary<string, int> _values = new Dictionary<string, int>();
        public void Set(string key, int value) { _values[key] = value; }
        public int? FindValue(string key) { int value; return _values.TryGetValue(key, out value) ? (int?)value : null; }
    }
    public class Task23_NullableValues : TaskBase
    {
        public override string Title { get { return "23. Nullable и null"; } }
        public override void Run()
        {
            SettingsStore store = new SettingsStore(); store.Set("volume", 7);
            int? found = store.FindValue("volume"); int? missing = store.FindValue("brightness");
            Console.WriteLine("volume: " + (found ?? 0));
            Console.WriteLine("brightness найден: " + missing.HasValue);
            Console.WriteLine("Значение brightness по умолчанию: " + (missing ?? 5));
            Console.WriteLine("Строка в верхнем регистре: " + ("hello" == null ? "нет строки" : "hello".ToUpper()));
        }
    }
}
