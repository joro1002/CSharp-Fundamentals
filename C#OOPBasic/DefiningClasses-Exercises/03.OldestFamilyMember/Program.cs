using System;

namespace _03.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            var family = new Family();

            int countPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPeople; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(tokens[0], int.Parse(tokens[1]));
               
                family.AddMember(person);
            }

            var oldPerson = family.GetOldestMember();

            if (oldPerson != null)
            {
                Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");
            }
        }
    }
}
