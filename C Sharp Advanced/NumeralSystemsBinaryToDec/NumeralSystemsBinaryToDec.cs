using System;
using System.Numerics;


namespace NumeralSystemsBinaryToDec
{
    class NumeralSystemsBinaryToDec
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();

            Console.WriteLine(ConvertToDecimal(binary, 2));
        }

        static BigInteger ConvertToDecimal(string number, int numeralBase)
        {
            BigInteger result = 0;

            foreach (char digit in number)
            {
                result = result * numeralBase + (digit - '0');
            }

            return result;
        }
    }
}
