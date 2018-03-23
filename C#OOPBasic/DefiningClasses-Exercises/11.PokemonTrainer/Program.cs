using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();
            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                var pokemonHealth = int.Parse(tokens[3]);

                var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }
                trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                trainers.Where(t => t.Pokemons.Any(p => p.Element == commands))
                    .ToList()
                    .ForEach(t => t.Badges++);

                var nonMatchingTrainers = trainers.Where(t => t.Pokemons.All(p => p.Element != commands));

                foreach (var nonMatchingTrainer in nonMatchingTrainers)
                {
                    nonMatchingTrainer.Pokemons.ForEach(p => p.Health -= 10);
                    nonMatchingTrainer.Pokemons = nonMatchingTrainer.Pokemons
                        .Where(p => p.Health > 0)
                        .ToList();
                }
                commands = Console.ReadLine();
            }
            trainers.OrderByDescending(t => t.Badges)
                .ToList()
                .ForEach(t => Console.WriteLine($"{t.Name} {t.Badges} {t.Pokemons.Count}"));
        }
    }
}
