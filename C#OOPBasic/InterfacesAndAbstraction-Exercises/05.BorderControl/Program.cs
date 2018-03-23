using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var society = new List<IIdentable>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                IIdentable member;
                var tokens = input.Split();

                if (tokens.Length == 3)
                {
                    member = new Citizens(tokens[0], int.Parse(tokens[1]), tokens[2]);
                }
                else
                {
                    member = new Robots(tokens[0], tokens[1]);
                }

                society.Add(member);
                input = Console.ReadLine();
            }

            var fakeIDs = Console.ReadLine();
            foreach (IIdentable member in society.Where(m => m.Id.EndsWith(fakeIDs)))
            {
                Console.WriteLine(member.Id);
            }
        }
    }
}
