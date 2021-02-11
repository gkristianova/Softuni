﻿using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                int sum = 0;
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sum += matrix[r, c];
                }
                Console.WriteLine(sum);

            }
        }
    }
}
