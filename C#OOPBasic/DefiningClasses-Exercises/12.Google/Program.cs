using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var persons = new List<Person>();

            while (input != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];

                var person = persons.FirstOrDefault(p => p.Name == name);

                if (person == null)
                {
                    person = new Person(name);
                    persons.Add(person);
                }

                var classCommand = tokens[1];

                switch (classCommand)
                {
                    case "company":
                        person.Company = new Company(tokens[2], tokens[3], decimal.Parse(tokens[4]));
                        break;

                    case "pokemon":
                        person.Pokemon.Add(new Pokemon(tokens[2], tokens[3]));
                        break;

                    case "parents":
                        person.Parents.Add(new Family(tokens[2], tokens[3]));
                        break;

                    case "children":
                        person.Children.Add(new Family(tokens[2], tokens[3]));
                        break;

                    case "car":
                        person.Car = new Car(tokens[2], int.Parse(tokens[3]));
                        break;
                }


                input = Console.ReadLine();
              
            }

            printPerson(persons);
        }

        private static void printPerson(List<Person> persons)
        {
            var filterName = Console.ReadLine();
            var person = persons.FirstOrDefault(p => p.Name == filterName);

            if (person != null)
            {
                Console.Write(person.ToString());
            }
        }
    }
}
