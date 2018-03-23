using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _04.OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
          var people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(tokens[0], int.Parse(tokens[1]));

               people.Add(person);
            }

            people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));



        }
    }
}
