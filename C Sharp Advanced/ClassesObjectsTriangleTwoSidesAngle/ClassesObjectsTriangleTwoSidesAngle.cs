using System;

namespace ClassesObjectsTriangleTwoSidesAngle
{
    class ClassesObjectsTriangleTwoSidesAngle
    {
        static void Main()
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = (double.Parse(Console.ReadLine())) * Math.PI / 180; // Turn degrees in radians!!!
            double sinC = Math.Sin(angle);

            double face = (a * b * sinC) / 2;

            Console.WriteLine("{0:0.00}", face);
        }
    }
}
