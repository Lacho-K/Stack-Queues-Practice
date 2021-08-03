using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack___reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            string resultString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            
            Console.WriteLine(String.Join(null,stack));
        }
    }
}
