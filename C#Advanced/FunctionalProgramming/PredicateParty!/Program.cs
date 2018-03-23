using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {
        private static List<string> names;

        static void Main(string[] args)
        {
            names = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string condition = tokens[1];

                switch (condition)
                {
                    case "StartsWith":
                        CommandProcess(names, command, n => n.StartsWith(tokens[2]));
                        break;
                    case "EndsWith":
                        CommandProcess(names, command, n => n.EndsWith(tokens[2]));
                        break;
                    case "Length":
                        CommandProcess(names, command, n => n.Length == int.Parse(tokens[2]));
                        break;
                }

                input = Console.ReadLine();

            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void CommandProcess(List<string> names, string command, Func<string, bool> func)
        {
            for (int i = names.Count - 1; i >= 0; i--)
            {
                if (func(names[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            names.RemoveAt(i);
                            break;
                        case "Double":
                            names.Add(names[i]);
                            break;
                        case "Lenght":
                            names.Add(names[i]);
                            break;
                    }
                }
            }
        }
    }
}
