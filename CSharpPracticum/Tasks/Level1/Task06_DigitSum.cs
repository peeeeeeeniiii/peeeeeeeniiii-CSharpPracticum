using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task06_DigitSum : TaskBase
    {
        public override string Title { get { return "6. Сумма цифр"; } }
        public override void Run()
        {
            int number = ReadInt("Введите целое число: ", 0);
            string digits = Math.Abs((long)number).ToString();
            int stringSum = 0;
            foreach (char digit in digits) stringSum += digit - '0';
            long n = Math.Abs((long)number);
            int arithmeticSum = 0;
            while (n > 0) { arithmeticSum += (int)(n % 10); n /= 10; }
            Console.WriteLine("Через строку: " + stringSum);
            Console.WriteLine("Арифметически: " + arithmeticSum);
        }
    }
}
