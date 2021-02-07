using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(input);
            int toss = int.Parse(Console.ReadLine());
            int count = 0;

            while (queue.Count > 1)
            {
                count++;
                if (count != toss)
                {
                    
                    string child = queue.Peek();
                    queue.Dequeue();
                    queue.Enqueue(child);
                    
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Peek()}");
                    queue.Dequeue();
                    count = 0;
                }
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
