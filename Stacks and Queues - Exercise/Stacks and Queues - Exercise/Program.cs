using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
namespace Stacks_and_Queues___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(input);
            while (songs.Count!=0)
            {
                string[] command = Console.ReadLine().Split();
             
                if(command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if(command[0] == "Add")
                {
                    string songToAdd = "";
                    for (int i = 1; i < command.Length; i++)
                    {
                        songToAdd += command[i];      
                        if(i<command.Length - 1)
                        {
                            songToAdd += " ";
                        }
                    }
                    if (!songs.Contains(songToAdd))
                    {
                        songs.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    
                }
                else if(command[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
            
        }
    }
}
