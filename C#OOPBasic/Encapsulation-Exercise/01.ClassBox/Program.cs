﻿using System;
using System.Net.Http.Headers;

namespace _01.ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

           var box = new Box(length, width, height);

            Console.WriteLine(box);
        }
    }
}
