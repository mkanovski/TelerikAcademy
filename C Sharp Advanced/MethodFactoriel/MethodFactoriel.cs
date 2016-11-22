using System;
using System.Numerics;

namespace MethodFactoriel
{
    class MethodFactoriel
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
                        
            Console.WriteLine(Factoriel(n));
        }

        static BigInteger Factoriel(BigInteger n)
        {
            BigInteger result = 1;
            for (BigInteger i = n; i > 0 ; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
