using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                int lineNumber = 0;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine($"{line}");
                    }

                    lineNumber++;
                }
            }
        }
    }
}
