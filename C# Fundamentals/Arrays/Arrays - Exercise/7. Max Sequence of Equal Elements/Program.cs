using System;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(" ").
                Select(int.Parse).
                ToArray();

            int tempTimes = 0;
            int times = 1;
            int maxTimes = 0;
            int sequence = 0;
            int finalSequence = 0;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    times++;
                    

                }
                else
                {
                    times = 1;
                    sequence = i;
                }
                if (times > maxTimes)
                {
                    maxTimes = times;
                    finalSequence = sequence;
                }      
            }
            if (maxTimes != 1)
            {
                for (int i = finalSequence; i < finalSequence + maxTimes; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(array[0]);
            }
           
            
            
            
        }
    }
}
