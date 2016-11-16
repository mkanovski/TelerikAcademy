using System;


namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = ((2 * width) + (2 * height));

            Console.WriteLine(String.Format("{0:f2} {1:f2}",area, perimeter));
        }
    }
}
