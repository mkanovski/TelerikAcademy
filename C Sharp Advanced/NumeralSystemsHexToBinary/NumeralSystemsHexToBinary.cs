using System;
using System.Numerics;

namespace NumeralSystemsHexToBinary
{
    class NumeralSystemsHexToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HexToDec(Console.ReadLine()));
        }

        static string HexToDec(string number)
        {
            string binary = "";
            for (int i = 0; i < number.Length; i++)
            {

                switch (number[i])
                {
                    case '0': binary = binary + "0000"; break;
                    case '1': binary = binary + "0001"; break;
                    case '2': binary = binary + "0010"; break;
                    case '3': binary = binary + "0011"; break;
                    case '4': binary = binary + "0100"; break;
                    case '5': binary = binary + "0101"; break;
                    case '6': binary = binary + "0110"; break;
                    case '7': binary = binary + "0111"; break;
                    case '8': binary = binary + "1000"; break;
                    case '9': binary = binary + "1001"; break;
                    case 'A': binary = binary + "1010"; break;
                    case 'B': binary = binary + "1011"; break;
                    case 'C': binary = binary + "1100"; break;
                    case 'D': binary = binary + "1101"; break;
                    case 'E': binary = binary + "1110"; break;
                    case 'F': binary = binary + "1111"; break;
                }
            }

            binary = binary.TrimStart('0');

            return binary;
        }
    }
}
