using System;
using System.Collections.Generic;
using System.Linq;
namespace Stacks_and_queles___more_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<int> qNums = new Queue<int>();
            Stack<string> stackSigns = new Stack<string>();
            
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        qNums.Enqueue(int.Parse(input[i].ToString()));
                       
                    }
                    else
                    {
                    
                        stackSigns.Push(input[i].ToString());
                    }
                    
                }
            Console.Write(string.Join(' ', qNums));
            Console.Write(string.Join(' ', stackSigns));
            
            
        }
    }
}
