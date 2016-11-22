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

        static string DecToHEX(BigInteger number)
        {
            string result = "";
            do
            {
                BigInteger leftoverNum = 0;

                if ((number % 16) % 1 == 0)
                {
                    leftoverNum = number % 16;
                }
                else
                {
                    leftoverNum = (number % 16) * 16;
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

                number /= 16;

            } while (number != 0);

            return result;
        }

        // HEX към бинарна система

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

        // Binary to HEX

        static string BinaryToHEX(string binary)
        {
            binary = binary.PadLeft(((binary.Length / 4) + 1) * 4, '0');

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

        // Any base number system to any other base numeral system ( 0 < base <= 16 )

        static string AnyToAny(string number, int inputBase, int outputBase)
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
