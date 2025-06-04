using System;

namespace MatrixApp
{
    public static class MatrixPrinter
    {
        public static void PrintMatrix(int[,] matrix)
        {
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j && i < size)
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write($"{matrix[i, j],4}");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
