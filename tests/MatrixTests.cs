using Xunit;
using MatrixApp;

namespace MatrixApp.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void Trace_SquareMatrix_ReturnsCorrectSum()
        {
            int[,] matrix = new int[,] {
                { 1, 2 },
                { 3, 4 }
            };

            int trace = MatrixAnalyzer.CalculateTrace(matrix);

            Assert.Equal(5, trace); // 1 + 4
        }

        [Fact]
        public void Trace_RectangularMatrix_ReturnsCorrectSum()
        {
            int[,] matrix = new int[,] {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };

            int trace = MatrixAnalyzer.CalculateTrace(matrix);

            Assert.Equal(60, trace); // 10 + 50
        }
    }
}
