using System;

namespace CircleAreaPerimeter
{
    class CircleAreaPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimeter = 2 * r * pi;
            double area = pi * r * r;

            Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
            
        }
    }
}
