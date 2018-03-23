using System;
using System.Collections.Generic;
using System.Linq;

namespace Inferno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gems = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var filters = new Dictionary<string, Func<List<int>, List<int>>>();
            var command = Console.ReadLine();
            while (command != "Forge")
            {
                ParseCommand(command, filters);

                command = Console.ReadLine();
            }
            List<int> filtered = GetFiltered(gems, filters);

            gems = gems.Where(gem => !filtered.Contains(gem)).ToList();
            Console.WriteLine(string.Join(" ", gems));

        }

        private static List<int> GetFiltered(List<int> gems, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            List<int> filtered = new List<int>();
            foreach (var filter in filters)
            {
                filtered.AddRange(filter.Value(gems));
            }
            return filtered;
        }

        private static void ParseCommand(string commandInput, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            string[] tokens = commandInput.Split(';');
            string command = tokens[0];
            string filterType = tokens[1];
            int parametar = int.Parse(tokens[2]);
            string dictKey = $"{filterType} {parametar}";

            if (command == "Exclude")
            {
                filters[dictKey] = CreateFunction(filterType, parametar);
            }
            else if (command == "Reverse")
            {
                filters.Remove(dictKey);
            }
           

        }

        private static Func<List<int>, List<int>> CreateFunction(string filterType, int parametar)
        {
            switch (filterType)
            {
                case "Sum Left":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int lefttGem = index > 0 ? gems[index - 1] : 0;
                        return gem + lefttGem == parametar;
                    }).ToList();

                case "Sum Right":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int rightGem = index < gems.Count - 1 ? gems[index + 1] : 0;
                        return gem + rightGem == parametar;
                    }).ToList();

                case "Sum Left Right":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int lefttGem = index > 0 ? gems[index - 1] : 0;
                        int rightGem = index < gems.Count - 1 ? gems[index + 1] : 0;
                        return lefttGem + gem + rightGem == parametar;
                    }).ToList();

                    default:
                    throw new ArgumentException();
                    
            }
        }
    }
}
