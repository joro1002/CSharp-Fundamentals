using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();

            stack.Push(1);
            stack.Push(1);

            for (int i = 1; i < n; i++)
            {
                var first = stack.Pop();
                var second = stack.Pop();

                stack.Push(first);
                stack.Push(first + second);
            }
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
