using System;

namespace ClassesObjectsTriangleThreeSides
{
    class ClassesObjectsTriangleThreeSides
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;

            double needA = p - a;
            double needB = p - b;
            double needC = p - c;

            double needSqrt = p * needA * needB * needC;

            double face = Math.Sqrt(needSqrt);

            Console.WriteLine("{0:0.00}", face);

        }
    }
}
