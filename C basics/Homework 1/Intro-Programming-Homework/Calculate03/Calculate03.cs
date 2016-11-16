using System;
using System.Numerics; 

namespace Calculate03
{
    class Calculate03
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger dif = n - k;
            BigInteger result1 = 1;

            for (BigInteger i = 1; i <= dif; i++)
            {
                result1 = result1 * n;
                n--;

            }

            BigInteger result2 = 1;
            BigInteger fac = dif;

            for (BigInteger i = 1; i <= dif; i++)
            {
                result2 = result2 * fac;
                fac--;
            }

            Console.WriteLine(result1 / result2);
        }
    }
}
