using System;
using System.Numerics;

namespace NumeralSystemsDecToBinary
{
    class NumeralSystemsDecToBinary
    {
        static void Main(string[] args)
        {
            BigInteger dec = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(DecToBinary(dec, 2));
        }

        static string DecToBinary(BigInteger dec, int numeralBase)
        {
            string result = "";
            if(dec % 1 == 0)
            { 
                do
                {
                    BigInteger digit = dec % numeralBase;
                    dec = dec / numeralBase;

                    result = digit + result;

                } while (dec > 0);
            }
            else
            {
                string number = dec.ToString();

                string[] numberArr = number.Split('.');

                string firstPart = numberArr[0];
                string secondPart = numberArr[1];

                BigInteger firstPartInt = BigInteger.Parse(firstPart);
                BigInteger secondPartInt = BigInteger.Parse(secondPart);

                firstPart = DecToBinary(firstPartInt, 2);
                secondPart = DecToBinary(secondPartInt, 2);

                result = firstPart + "." + secondPart;
            }
            return result;
        }
    }
}
