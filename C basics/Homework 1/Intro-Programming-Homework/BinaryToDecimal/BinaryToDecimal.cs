using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            BigInteger binary = BigInteger.Parse(Console.ReadLine());
            double result = 0;
            double smetka = 0;
            double stepen = 0;
            do
            {
                if (binary % 10 == 0)
                {
                    result = result + 0;
                    stepen++;
                    binary = binary / 10;
                }
                else
                {
                    smetka = Math.Pow(2, stepen);
                    result = result + smetka;
                    binary = binary / 10;
                    stepen++;
                }
            } while (binary > 0);
            Console.WriteLine(result);
        
        }
    }
}
