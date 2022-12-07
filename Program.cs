using System;

namespace GB_HW47
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количетсво строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[m, n];
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(rand.Next(-50, 50) / 1.5, 1);
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
