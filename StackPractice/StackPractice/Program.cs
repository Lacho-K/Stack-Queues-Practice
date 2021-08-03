using System;
using System.Collections.Generic;

namespace DECToBIN
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(checkBrackets(input));
        }
        static bool checkBrackets(string input)
        {
            Stack<char> checkStack = new Stack<char>();
            foreach (var bracket in input)
            {
                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    checkStack.Push(bracket);
                }
                else if (bracket == ')' || bracket == ']' || bracket == '}')
                {
                    if (checkStack.Count <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        char skoba = checkStack.Pop();
                        switch (bracket)
                        {
                            case ')':
                                if (skoba != '(')
                                    return false;
                                break;
                            case ']':
                                if (skoba != '[')
                                    return false;
                                break;
                            case '}':
                                if (skoba != '{')
                                    return false;
                                break;
                        }
                    }
                }
            }
            if (checkStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
