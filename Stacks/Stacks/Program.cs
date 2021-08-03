using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>(input.Split());
            stack.Reverse();
            int sum = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {                                
                char sign = char.Parse(stack.Pop());               
                int num = int.Parse(stack.Pop());
                if (sign == '+')
                {
                    sum += num;
                }
                else if (sign == '-')
                {
                    sum -= num;
                }
                                              

            }
            Console.WriteLine(sum);
        }
    }
}
