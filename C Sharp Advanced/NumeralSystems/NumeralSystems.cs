using System;

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
    }
}
