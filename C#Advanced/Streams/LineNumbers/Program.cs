using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    int lineNumber = 1;

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        
                           writer.Write($"Line {lineNumber++}: {line}");
                        writer.Write(Environment.NewLine);
                    }
                }
            
            }
        }
    }
}
