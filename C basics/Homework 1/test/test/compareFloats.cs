﻿using System;

namespace CompareFloats
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (((a - b) > eps) || ((a - b) < 0))
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
                        
        }
    }
}
