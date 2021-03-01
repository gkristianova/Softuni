using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(" ").
                Select(int.Parse).
                ToArray();

            //14 24 3 19 15 17 


            for (int i = 0; i < array.Length - 1; i++)
            {
                
                if (array[i] > array[i+1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.Write(array[array.Length - 1]);
        }

    }
}
