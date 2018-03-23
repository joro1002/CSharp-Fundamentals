using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ReversedNumberWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            var stack = new Stack<int>();

            foreach (var number in numbers)
            {
              stack.Push(number);
                
            }
            Console.WriteLine(string.Join(" ", stack));
            
        }
    }
}
