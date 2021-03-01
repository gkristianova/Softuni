using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().
                Split(" ").
                Select(int.Parse).
                ToArray();

                if (i % 2 == 0)
                {
                    arr1[i] = numbers[0];
                    arr2[i] = numbers[1];
                }
                else
                {
                    arr1[i] = numbers[1];
                    arr2[i] = numbers[0];
                }
            }

            foreach (int num1 in arr1)
            {
                Console.Write(num1 + " ");
            }
            Console.WriteLine();
            foreach (int num2 in arr2)
            {
                
                Console.Write(num2 + " ");
            }



        }
    }
}
