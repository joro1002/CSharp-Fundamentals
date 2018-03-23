using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.CatLady
{
    class Program
    {
        static void Main(string[] args)
        {
            var cats = GetCats();

            var searchedName = Console.ReadLine();
            var cat = cats.FirstOrDefault(c => c.Name == searchedName);

            if (cat != null)
            {
                Console.WriteLine(cat.ToString());
            }
        }

        private static List<Cat> GetCats()
        {
            var cats = new List<Cat>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var catInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var breed = catInfo[0];
                var name = catInfo[1];
                var breedSpecificInfo = catInfo[2];

                Cat cat = new Cat(breed, name);
                switch (breed)
                {
                    case "Siamese":
                        cat = new Siamese(breed, name, int.Parse(breedSpecificInfo));
                        break;
                    case "Cymric":
                        cat = new Cymric(breed, name, double.Parse(breedSpecificInfo));
                        break;
                    case "StreetExtraordinaire":
                        cat = new StreetExtraordinaire(breed, name, int.Parse(breedSpecificInfo));
                        break;
                }
                cats.Add(cat);
            }
            return cats;
        }
    }
}


