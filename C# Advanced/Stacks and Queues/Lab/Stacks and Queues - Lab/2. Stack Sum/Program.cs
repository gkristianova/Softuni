using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commandInput = Console.ReadLine().Split();
            string command = commandInput[0].ToLower();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            int sum = 0;
            while (command != "end")
            {

                switch (command)
                {
                    case "add":
                        stack.Push(int.Parse(commandInput[1]));
                        stack.Push(int.Parse(commandInput[2]));
                        break;
                    case "remove":
                        if (stack.Count >= int.Parse(commandInput[1]))
                        {
                            for (int i = 0; i < int.Parse(commandInput[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
                commandInput = Console.ReadLine().Split();
                command = commandInput[0].ToLower();
            }
            int length = stack.Count;
            for (int i = 0; i < length; i++)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
