using System;

namespace MatrixApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            var matrix = MatrixGenerator.GenerateMatrix(rows, cols);
            Console.WriteLine("\nGenerated Matrix:");
            MatrixPrinter.PrintMatrix(matrix);

            int trace = MatrixAnalyzer.CalculateTrace(matrix);
            Console.WriteLine($"\nMatrix trace: {trace}");
        }
    }
}
