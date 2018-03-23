using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SalaryIncrease
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

                var person = new Person(tokens[0], tokens[1], int.Parse(tokens[2]), decimal.Parse(tokens[3]));

                persons.Add(person);
            }

            var percentage = decimal.Parse(Console.ReadLine());
          persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p=> Console.WriteLine(p.ToString()));
        }
    }
}
