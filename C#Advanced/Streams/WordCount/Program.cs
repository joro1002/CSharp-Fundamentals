using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = ReadWords();

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tokens = line.Split("- ,?!.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(t => t.ToLower()).ToArray();

                    foreach (var token in tokens)
                    {
                        if (words.ContainsKey(token))
                        {
                            words[token]++;
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                foreach (var word in words.OrderByDescending(w => w.Value))
                {
                    writer.Write($"{word.Key} - {word.Value}");
                    writer.Write(Environment.NewLine);
                }
            }
        }

        private static Dictionary<string, int> ReadWords()
        {
            using (StreamReader reader = new StreamReader("words.txt"))
            {
                Dictionary<string, int> words = new Dictionary<string, int>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    words.Add(line.ToLower(), 0);
                }

                return words;
            }
        }
    }
}
