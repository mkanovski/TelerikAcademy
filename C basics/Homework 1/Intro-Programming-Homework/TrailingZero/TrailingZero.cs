using System;
using System.Numerics;


namespace TrailingZero
{
    class TrailingZero
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger fives = 0;
            BigInteger twos = 0;
            int devider1 = 5;
            int devider2 = 2;

            while (n > devider1)
            {
                fives = fives + (n / devider1);
                devider1 = devider1 * 5;

            }

            while (n > devider2)
            {
                twos = twos + (n / devider2);
                devider2 = devider2 * 2;

            } 

            Console.WriteLine(fives);
        }
    }
}
