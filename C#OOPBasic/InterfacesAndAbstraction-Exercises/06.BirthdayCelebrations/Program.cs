using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthable = new List<IBirthday>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var inputArgs = input.Split().ToList();

                var typeOfMember = inputArgs[0];
                inputArgs.RemoveAt(0);

                IBirthday currentMember;
                switch (typeOfMember)
                {
                    case "Citizen":
                        currentMember = new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3]);
                        birthable.Add(currentMember);
                        break;

                    case "Pet":
                        currentMember = new Pet(inputArgs[0], inputArgs[1]);
                        birthable.Add(currentMember);
                        break;

                    default:
                        break;
                }


                input = Console.ReadLine();
            }

            var year = Console.ReadLine();

            var filtered = birthable
                .Where(m => m.BirthDay.EndsWith(year))
                .ToArray();

            foreach (IBirthday member in filtered)
            {
                Console.WriteLine(member.BirthDay);
            }
        }
    }
}
