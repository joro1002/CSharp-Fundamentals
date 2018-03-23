using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> func = n => n % 2 != 0;

           Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(n => func(n))
                .ThenBy(n =>n)
                .ToList()
                .ForEach(n => Console.Write($"{n} "));
          
        }
    }
}
