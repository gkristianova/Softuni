using System;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] people = new int[n];

            for (int i = 0; i < n; i++)
            {
                int numPeople = int.Parse(Console.ReadLine());
                sum += numPeople;
                people[i] = numPeople; 
            }

            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
