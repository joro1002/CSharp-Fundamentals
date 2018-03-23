using System;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var indexes = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commad = Console.ReadLine();

            Predicate<int> predicate = num => commad == "even" ? num % 2 == 0 : num % 2 != 0;

            for (int num = indexes[0]; num <= indexes[1]; num++)
            {
                if (predicate(num))
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();

        }
    }
}
