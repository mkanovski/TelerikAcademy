using System;
using System.Numerics;

namespace NumeralSystems
{
    class NumeralSystems
    {
        static void Main()
        {
            // Десетична бройна система 2983 = 2*10^3 + 9*10^2 + 8*10^1 + 3*10^0
            //
            // Универсална формула за превръщане към десетична
            // abcd - число ; B - база (големината на бройната система
            // а*B^3 + b*B^2 + c*B^1 + d*B^0
            //
            //

        }
        // Метод за превръщане на бройни системи с база от 1 до 10 към десетична бройна система
        static int ConvertToDecimal(string number, int numeralBase)
        {
            int result = 0;

            foreach (char digit in number)
            {
                result = result * numeralBase + (digit - '0');
            }

            return result;
        }

        // Метод за превръщане на HEX към десетична бройна система

        static int ConvertFromHextoDec(string number)
        {
            int result = 0;

            foreach (char digit in number)
            {
                int digitValue;
                if(char.IsDigit(digit))
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

        // Метод за десетична бройна към двуична

        static string DecToBinary(int dec, int numberalBase)
        {
            string result = "";

            do
            {
                int digit = dec % numberalBase;
                dec = dec / numberalBase;

                result = digit + result;

            } while (dec > 0);

            return result;
        }

        // Метод за превръщане на десетична към HEX

        static string DecToHEX(int number)
        {
            string result = "";
            do
            {
                switch ((number % 16)*16)
                {
                    case 0: result = "0" + result; break;
                    case 1: result = "1" + result; break;
                    case 2: result = "2" + result; break;
                    case 3: result = "3" + result; break;
                    case 4: result = "4" + result; break;
                    case 5: result = "5" + result; break;
                    case 6: result = "6" + result; break;
                    case 7: result = "7" + result; break;
                    case 8: result = "8" + result; break;
                    case 9: result = "9" + result; break;
                    case 10: result = "A" + result; break;
                    case 11: result = "B" + result; break;
                    case 12: result = "C" + result; break;
                    case 13: result = "D" + result; break;
                    case 14: result = "E" + result; break;
                    case 15: result = "F" + result; break;
                }

            } while (number != 0);

            return result;
        }
    }
}
