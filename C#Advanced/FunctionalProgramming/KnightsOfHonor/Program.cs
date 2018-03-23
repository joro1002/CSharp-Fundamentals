using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = name => Console.WriteLine($"Sir {name}");

            Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList()
                            .ForEach(action);
        }
    }
}
