namespace MatrixApp
{
    public static class MatrixAnalyzer
    {
        public static int CalculateTrace(int[,] matrix)
        {
            int trace = 0;
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

            for (int i = 0; i < size; i++)
                trace += matrix[i, i];

            return trace;
        }
    }
}
