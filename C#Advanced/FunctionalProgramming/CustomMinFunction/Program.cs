using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            int minValue = int.MaxValue;
            Func<int, bool> func = n => n < minValue;


           var numbers =  Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            foreach (var num in numbers)
            {
                if (func(num))
                {
                    minValue = num;
                }
            }
            Console.WriteLine(minValue);





        }
        
    }
}
