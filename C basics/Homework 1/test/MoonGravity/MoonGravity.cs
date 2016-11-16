using System;

namespace MoonGravity
{
    class moonGravity
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double m = w * 0.17;
            Console.WriteLine(String.Format("{0:0.000}", m));
        }
    }
}
