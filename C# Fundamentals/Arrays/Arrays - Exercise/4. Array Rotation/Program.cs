using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                Split(" ").
                Select(int.Parse).
                ToArray();

            int n = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < n; i++)
            {

                int firstElement = numbers[0];

                int[] tempArr = new int[numbers.Length];

                for (int j = 1; j < numbers.Length; j++)
                {
                    tempArr[j - 1] = numbers[j];
                }

                tempArr[tempArr.Length - 1] = firstElement;
                numbers = tempArr;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
