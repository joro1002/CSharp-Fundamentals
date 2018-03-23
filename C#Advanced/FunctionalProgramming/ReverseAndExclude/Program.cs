using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int divised = int.Parse(Console.ReadLine());

           Func<int, bool> func = n => n % divised != 0;

            foreach (var number in numbers)
            {
                if (func(number))
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }
    }
}
