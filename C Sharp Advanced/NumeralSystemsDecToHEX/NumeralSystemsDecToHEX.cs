using System;
using System.Numerics;


namespace NumeralSystemsDecToHEX
{
    class NumeralSystemsDecToHEX
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(DecToHEX(n));
        }

        static string DecToHEX(int number)
        {
            string result = "";
            do
            {
                switch ((number % 16) * 16)
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

                number /= 16;

            } while (number != 0);

            return result;
        }
    }
}
