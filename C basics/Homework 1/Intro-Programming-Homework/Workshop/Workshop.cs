using System;
using System.Numerics;

namespace Workshop
{
    class Workshop
    {
        static void Main()
        {

            double b = long.Parse(Console.ReadLine());
            double f = long.Parse(Console.ReadLine());
            double avg = f / b;
            

            if (b % 2 == 0)
            {
                Console.WriteLine("{0:0.0000}", (avg * 123123123123));
            }
            else
            {
                Console.WriteLine("{0:0.0000}", (avg / 317));
            }
        }
    }
}
