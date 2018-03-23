using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string command = input;

                if (command == "add")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]++;
                    }
                }
                else if(command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else if (command == "multiply")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] *= 2;
                    }
                }
                else if (command == "subtract")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
                input = Console.ReadLine();
            }
         
        }
    }
}
