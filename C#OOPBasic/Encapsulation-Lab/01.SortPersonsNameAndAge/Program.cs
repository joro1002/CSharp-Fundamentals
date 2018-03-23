using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _01.SortPersonsNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(tokens[0], tokens[1], int.Parse(tokens[2]));

                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}
