using System;
using System.Numerics;

namespace NumeralSystemsAnyToAny
{
    class NumeralSystemsAnyToAny
    {
        static void Main()
        {
            Console.WriteLine(AnyToAny(int.Parse(Console.ReadLine()), Console.ReadLine(), int.Parse(Console.ReadLine())));
        }

        static string AnyToAny(int inputBase, string number, int outputBase)
        {
            BigInteger resultDec = 0;

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

                resultDec = resultDec * inputBase + digitValue;
            }

            string result = "";
            do
            {
                BigInteger leftoverNum = 0;

                if ((resultDec % outputBase) % 1 == 0)
                {
                    leftoverNum = resultDec % outputBase;
                }
                else
                {
                    leftoverNum = (resultDec % outputBase) * outputBase;
                }

                string leftover = leftoverNum.ToString();

                switch (leftover)
                {
                    case "0": result = "0" + result; break;
                    case "1": result = "1" + result; break;
                    case "2": result = "2" + result; break;
                    case "3": result = "3" + result; break;
                    case "4": result = "4" + result; break;
                    case "5": result = "5" + result; break;
                    case "6": result = "6" + result; break;
                    case "7": result = "7" + result; break;
                    case "8": result = "8" + result; break;
                    case "9": result = "9" + result; break;
                    case "10": result = "A" + result; break;
                    case "11": result = "B" + result; break;
                    case "12": result = "C" + result; break;
                    case "13": result = "D" + result; break;
                    case "14": result = "E" + result; break;
                    case "15": result = "F" + result; break;
                }

                resultDec /= outputBase;

            } while (resultDec != 0);

            return result;

        }
    }
}
