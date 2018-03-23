﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var  text = new StringBuilder();
            var history = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        if (input.Length > 1)
                        {
                            history.Push(text.ToString());
                            text.Append(input[1]);
                        }
                        break;

                    case 2:

                        if (input.Length > 1)
                        {
                            var count = int.Parse(input[1]);
                            history.Push(text.ToString());

                            if (count > text.Length)
                            {
                                text.Clear();
                                break;
                            }
                            text.Remove(text.Length - count, count);
                        }
                        break;


                    case 3:
                        if (input.Length > 1)
                        {
                            var index = int.Parse(input[1]);
                            if (index <= text.Length && index > 0)
                                Console.WriteLine(text[index - 1]);
                        }

                        break;

                    case 4:
                        text.Clear();
                        text.Append(history.Pop());
                        break;

                }
            }
        }
    }
}
