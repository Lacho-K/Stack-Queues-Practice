using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___evenMoreExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> liters = new Queue<int>();
            bool circling = true;
            int startIndex = int.MinValue;
            int endOfCircle = 0;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                liters.Enqueue(input[0] - input[1]);

            }
            while (true)
            {               
                foreach (int currentlitters in liters)
                {
                    int streak = 0;
                    if (currentlitters > 0)
                    {
                        streak = currentlitters;
                        startIndex = liters.ToList().IndexOf(currentlitters);
                        endOfCircle = currentlitters;
                    }
                    else
                    {
                        streak -= currentlitters;
                    }
                    if (streak < 0)
                    {
                        streak = 0;
                        startIndex = int.MinValue;
                        circling = false;
                        break;
                    }
                }
            }
            
        }
    }
}
