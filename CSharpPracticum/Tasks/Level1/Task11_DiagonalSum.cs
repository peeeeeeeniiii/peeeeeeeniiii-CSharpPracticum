using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level1
{
    public class Task11_DiagonalSum : TaskBase
    {
        public override string Title { get { return "11. Сумма диагонали матрицы"; } }
        public override void Run()
        {
            int n = ReadInt("Размер матрицы (не меньше 2): ", 3);
            if (n < 2) n = 2;
            int[,] matrix = new int[n, n]; Random random = new Random(); int sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) matrix[i, j] = random.Next(1, 10);
            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write("{0,4}", matrix[i, j]);
                Console.WriteLine();
                sum += matrix[i, i];
            }
            Console.WriteLine("Сумма главной диагонали: " + sum);
        }
    }
}
