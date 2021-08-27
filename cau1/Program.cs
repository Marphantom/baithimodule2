using System;

namespace cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = CreateMatrix();
            int max = FindMax(matrix);
            Console.WriteLine($"Max value: {max}");
            ShowMatrix(matrix);
        }
        public static int[,] CreateMatrix()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for(int i=0; i< matrix.GetLength(0); i++)
            {
                for(int j=0; j< matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(10,50);
                }
            }
            return matrix;
        }

        public static int FindMax(int[,] matrix)
        {
            int max = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        public static void ShowMatrix(int[,] matrix)
        {
                for(int i=0; i< matrix.GetLength(0); i++){
                    for(int j=0; j<=i; j++){
                        Console.Write($"{matrix[i,j]} ");
                    }
                    Console.WriteLine();
            }
        }
    }
}