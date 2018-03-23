using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsUpper(x.First()))
                .ToList()
                .ForEach(n => Console.WriteLine(n));
        }
    }
}
