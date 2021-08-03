using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Text_editor___stack_and_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOperations = int.Parse(Console.ReadLine());
            string resultText = string.Empty;
            Stack<string> undo = new Stack<string>();
            for (int i = 0; i < nOperations; i++)
            {
                string[] currentOp = Console.ReadLine().Split();
                if(currentOp[0] == "1")
                {
                    resultText += currentOp[1];
                }
                else if(currentOp[0] == "2")
                {
                    for (int j = 0; j < int.Parse(currentOp[1]); j++)
                    {
                        resultText.Remove(resultText[j]);
                    }
                }
                else if(currentOp[0] == "3")
                {
                    Console.WriteLine(resultText.Take(int.Parse(currentOp[1])));
                }
                else
                {

                }
            }
        }
    }
}
