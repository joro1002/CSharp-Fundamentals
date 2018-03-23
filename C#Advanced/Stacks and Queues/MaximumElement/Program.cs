using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var  stack = new Stack<int>();
            var stackMax = new Stack<int>();

            stackMax.Push(int.MinValue);

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                

                switch (commands[0])
                {
                    case 1:
                        var element = commands[1];
                        stack.Push(element);
                        if (element >= stackMax.Peek())
                        {
                            stackMax.Push(element);
                        }
                        break;

                    case 2:
                        var poppoedElement = stack.Pop();
                        if (stackMax.Peek() == poppoedElement)
                        {
                            stackMax.Pop();
                        }
                        break;
                    case 3:
                        Console.WriteLine(stackMax.Peek());
                        break;
                }
            }
        }
    }
}
