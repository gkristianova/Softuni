using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var squareSum = matrix[row, col] +
                       matrix[row + 1, col] +
                       matrix[row, col + 1] +
                       matrix[row + 1, col + 1];


                    if (squareSum > maxSum)
                    {
                        maxSum = squareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }


            for (int row = maxSumRow; row < maxSumRow + n; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
