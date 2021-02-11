using System;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)

            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            char symbol = Console.ReadLine()[0];
            int currRow = -1;
            int currCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isFound = true;
                        currRow = row;
                        currCol = col;
                        break;

                    }

                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"({currRow}, {currCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
    }
}


