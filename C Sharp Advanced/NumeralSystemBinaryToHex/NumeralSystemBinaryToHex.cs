using System;

namespace NumeralSystemBinaryToHex
{
    class NumeralSystemBinaryToHex
    {
        static void Main()
        {
            Console.WriteLine(BinaryToHEX(Console.ReadLine()));
        }

        static string BinaryToHEX(string binary)
        {
            binary = binary.PadLeft((((binary.Length + 1) / 4) + 1) * 4, '0');

            string hex = "";
            int index = 0;

            for (int i = 0; i < binary.Length / 4; i++)
            {
                string digit = binary.Substring(index, 4);

                switch (digit)
                {
                    case "0000": hex = hex + '0'; break;
                    case "0001": hex = hex + '1'; break;
                    case "0010": hex = hex + '2'; break;
                    case "0011": hex = hex + '3'; break;
                    case "0100": hex = hex + '4'; break;
                    case "0101": hex = hex + '5'; break;
                    case "0110": hex = hex + '6'; break;
                    case "0111": hex = hex + '7'; break;
                    case "1000": hex = hex + '8'; break;
                    case "1001": hex = hex + '9'; break;
                    case "1010": hex = hex + 'A'; break;
                    case "1011": hex = hex + 'B'; break;
                    case "1100": hex = hex + 'C'; break;
                    case "1101": hex = hex + 'D'; break;
                    case "1110": hex = hex + 'E'; break;
                    case "1111": hex = hex + 'F'; break;
                }

                index = index + 4;

            }

            hex = hex.TrimStart('0');

            return hex;
        }
    }
}
