using System;
using System.Buffers;
using System.Linq;
using System.Threading;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

           

            int n = int.Parse(Console.ReadLine());
            
            int times = 1;
            int temptimes = 0;
            int maxTimes = 0;
            int currentDNA = 0;
            int savedDNA = 0;
            int sumSequence = 0;
            int maxSumSequence = 0;
            int[] sequences = new int[n];
            int[] bestSequence = new int[n];
            int tempstart = 0;
            int beststart = 0;
           
            string input = Console.ReadLine();

            
            while (input != "Clone them!")
            {
                                        //   1 1 0 0
                                        //   0 1 2 3

                currentDNA++;

                times = 1;
                sumSequence = 0;
                tempstart = 0;

                sequences = input.Split("!").Select(int.Parse).ToArray();

                for (int i = 0; i < n - 1; i++)
                {
                    if (sequences[i] == sequences[i + 1] )
                    {

                        times++;
                        
                    }
                    else
                    {
                        times = 1;
                    }
                    if (times > temptimes)
                    {
                        temptimes = times;
                        tempstart = i;
                    }
                }
                for (int i = 0; i < n;i++)
                {
                    sumSequence += sequences[i];
                }

                if (temptimes > maxTimes)
                {
                    maxTimes = temptimes;
                    beststart = tempstart;
                    maxSumSequence = sumSequence;
                    savedDNA = currentDNA;
                    bestSequence = sequences;

                }
                else if (temptimes == maxTimes)
                {
                    if (tempstart < beststart)
                    {
                        maxTimes = temptimes;
                        beststart = tempstart;
                        maxSumSequence = sumSequence;
                        savedDNA = currentDNA;
                        bestSequence = sequences;
                    }
                    else if (tempstart == beststart)
                    {
                        if (sumSequence >maxSumSequence)
                        {
                            maxTimes = temptimes;
                            beststart = tempstart;
                            maxSumSequence = sumSequence;
                            savedDNA = currentDNA;
                            bestSequence = sequences;
                        }
                    }
                }

               


                input = Console.ReadLine();

            }

            Console.WriteLine($"Best DNA sample {savedDNA} with sum: {maxSumSequence}.");
            foreach (var item in bestSequence)
            {
                Console.Write(item + " ");
            }





        }
    }
}
