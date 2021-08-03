using System;
using System.Collections;
using System.Collections.Generic;
namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if(input != "Paid")
                {
                    people.Enqueue(input);
                }
                else
                {
                    foreach (var person in people)
                    {
                        Console.WriteLine(person);
                    }
                    people.Clear();
                }
            }
            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
