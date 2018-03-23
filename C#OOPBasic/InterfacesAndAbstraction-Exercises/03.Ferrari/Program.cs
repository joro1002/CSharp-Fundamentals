using System;

namespace _03.Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            var ferrari = new global::Ferrari(name);

            Console.WriteLine(ferrari);
        }
    }
}
