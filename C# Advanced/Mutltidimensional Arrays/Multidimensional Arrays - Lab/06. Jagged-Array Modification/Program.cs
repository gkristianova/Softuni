using System;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split();
                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                int currRow = int.Parse(command[1]);
                int currCol = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (command[0] == "Add")
                {
                    if (currRow >= 0 && jagged.Length > currRow && currCol >= 0)
                    {
                        if (jagged[currRow].Length > currCol)
                        {
                            jagged[currRow][currCol] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        
                    }
                    else if (jagged.Length <= currRow || currRow < 0 || currCol < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                if (command[0] == "Subtract")
                {
                    if (currRow >= 0 && jagged.Length > currRow && currCol >= 0)
                    {
                        if (jagged[currRow].Length > currCol)
                        {
                            jagged[currRow][currCol] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                    }
                    else if (jagged.Length <= currRow || currRow < 0 || currCol < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                command = Console.ReadLine().Split();
            }
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}
