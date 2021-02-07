using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int count = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    if (queue.Count < n)
                    {
                        int newN = queue.Count;
                        for (int i = 0; i < newN; i++)
                        {
                            Console.WriteLine($"{queue.Peek()} passed!");
                            queue.Dequeue();
                            count++;

                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{queue.Peek()} passed!");
                            queue.Dequeue();
                            count++;

                        }
                    }
                    
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
