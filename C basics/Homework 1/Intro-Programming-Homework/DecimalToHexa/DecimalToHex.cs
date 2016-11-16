using System;
using System.Numerics;


namespace DecimalToHexa
{
    class DecimalToHex
    {
        static void Main()
        {
            BigInteger dec = int.Parse(Console.ReadLine());
            string hex = "";
            BigInteger remain = 0;

            do
            {
                remain = dec % 16;
                switch ((int)remain)
                {
                    case 10: hex = "A" + hex; break;
                    case 11: hex = "B" + hex; break;
                    case 12: hex = "C" + hex; break;
                    case 13: hex = "D" + hex; break;
                    case 14: hex = "E" + hex; break;
                    case 15: hex = "F" + hex; break;
                    default: hex = remain + hex; break;
                }
                dec = dec / 16;
            } while (dec != 0);
            Console.WriteLine(hex);

        }
    }
}
