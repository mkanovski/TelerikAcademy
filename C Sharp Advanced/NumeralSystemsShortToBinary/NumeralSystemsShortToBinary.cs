using System;

namespace NumeralSystemsShortToBinary
{
    class NumeralSystemsShortToBinary
    {
        static void Main()
        {
            Console.WriteLine(DecToBinary(int.Parse(Console.ReadLine())));
        }

        static string DecToBinary(int dec, int numeralBase = 2)
        {
            // Определям първата цифра на бинарното число спрямо стойността на подаденото число
            char prefix;
            if (dec >= 0)
            {
                prefix = '0';
            }
            else
            {
                prefix = '1';
            }

            // Ако подаденото число е негативно, намирам числото чиято бинарна стойност трябва да се намери
            if( dec < 0)
            {
                dec = short.MaxValue + dec + 1;
            }

            string result = "";

            // Правя класическо конвертиране от десетична към двоична
            do
            {
                int digit = dec % numeralBase;
                dec = dec / numeralBase;

                result = digit + result;

            } while (dec > 0);

            // Подравнявам до 16 бита с 0 при положително и с 1 за отрицателно
            result = result.PadLeft(15, '0');

            // Слагам префикса на първа позиция
            result = prefix + result;

            return result;

        }
    }
}
