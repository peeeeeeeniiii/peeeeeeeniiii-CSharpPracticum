using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class Temperature
    {
        private double _celsius;
        public double Celsius
        {
            get { return _celsius; }
            set { if (value < -273.15) throw new ArgumentOutOfRangeException("value", "Температура не может быть ниже абсолютного нуля."); _celsius = value; }
        }
        public double Fahrenheit { get { return Celsius * 9 / 5 + 32; } }
    }
    public class Task32_Temperature : TaskBase
    {
        public override string Title { get { return "32. Свойства температуры"; } }
        public override void Run()
        {
            Temperature t = new Temperature(); t.Celsius = 25;
            Console.WriteLine(t.Celsius + " °C = " + t.Fahrenheit + " °F");
            try { t.Celsius = -300; }
            catch (ArgumentOutOfRangeException ex) { Console.WriteLine("Ошибка: " + ex.Message); }
        }
    }
}
