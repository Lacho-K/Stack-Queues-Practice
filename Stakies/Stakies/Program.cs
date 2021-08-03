using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stakies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> result = new Queue<int>();
            int[] numsToAdd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < nums[0]; i++)
            {
                result.Enqueue(numsToAdd[i]);
            }
            for (int i = 0; i < nums[1]; i++)
            {
                result.Dequeue();
            }
            if (result.Contains(nums[2]))
            {
                Console.WriteLine("true");
            }
            else if (!result.Contains(nums[2]) && result.Count > 0)
            {
                int smallest = result.Peek();
                foreach (var num in result)
                {
                    if (num < smallest)
                    {
                        smallest = num;
                    }
                }
                Console.WriteLine(smallest);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
