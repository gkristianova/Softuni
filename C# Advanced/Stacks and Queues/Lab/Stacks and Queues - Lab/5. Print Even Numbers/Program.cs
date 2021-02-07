﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    queue.Enqueue(input[i]);
                }
            }
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(string.Join(queue.Peek);
            }

            
        }
    }
}
