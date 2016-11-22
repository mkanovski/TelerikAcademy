using System;
using System.Numerics;

namespace NumeralSystemHexToDec
{
    class NumeralSystemHexToDec
    {
        static void Main()
        {
            Console.WriteLine(ConvertFromHextoDec(Console.ReadLine()));
        }

        static BigInteger ConvertFromHextoDec(string number)
        {
            BigInteger result = 0;

            foreach (char digit in number)
            {
                int digitValue;
                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = digit - 'A' + 10;
                }

                result = result * 16 + digitValue;
            }

            return result;
        }
    }
}
