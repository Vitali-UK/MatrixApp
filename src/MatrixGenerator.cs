using System;

namespace MatrixApp
{
    public static class MatrixGenerator
    {
        public static int[,] GenerateMatrix(int rows, int columns)
        {
            var rand = new Random();
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = rand.Next(0, 101);

            return matrix;
        }
    }
}
