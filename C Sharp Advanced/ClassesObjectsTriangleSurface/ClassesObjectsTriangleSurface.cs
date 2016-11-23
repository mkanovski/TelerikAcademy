using System;


namespace ClassesObjectsTriangleSurface
{
    class ClassesObjectsTriangleSurface
    {
        static void Main()
        {

            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double face = (side * h) / 2;

            Console.WriteLine("{0:0.00}", face);
        }
    }
}
