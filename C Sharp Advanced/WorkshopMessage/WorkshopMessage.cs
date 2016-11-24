using System;
using System.Numerics;


namespace WorkshopMessage
{
    class Program
    {
        static void Main()
        {
            BigInteger input = CodeToDec(Console.ReadLine());
            string op = Console.ReadLine();
            BigInteger input2 = CodeToDec(Console.ReadLine());

            if(op == "-")
            {
                Console.WriteLine(DecToCode(input - input2));
            }
            else
            {
                Console.WriteLine(DecToCode(input + input2));
            }

        }

        static BigInteger CodeToDec(string number)
        {
            string result = "";
            for (int i = 0; i < number.Length;)
            {

                string digit = number.Substring(i, 3);

                switch (digit)
                {
                    case "cad": result = result + '0'; break;
                    case "xoz": result = result + '1'; break;
                    case "nop": result = result + '2'; break;
                    case "cyk": result = result + '3'; break;
                    case "min": result = result + '4'; break;
                    case "mar": result = result + '5'; break;
                    case "kon": result = result + '6'; break;
                    case "iva": result = result + '7'; break;
                    case "ogi": result = result + '8'; break;
                    case "yan": result = result + '9'; break;

                }

                i = i + 3;

            }

            BigInteger resultNum = BigInteger.Parse(result);

            return resultNum;
        }

        static string DecToCode(BigInteger numberNum)
        {
            string number = numberNum.ToString();
            string result = "";
            for (int i = 0; i < number.Length; i++)
            {

                char digit = number[i];

                switch (digit)
                {
                    case '0': result = result + "cad"; break;
                    case '1': result = result + "xoz"; break;
                    case '2': result = result + "nop"; break;
                    case '3': result = result + "cyk"; break;
                    case '4': result = result + "min"; break;
                    case '5': result = result + "mar"; break;
                    case '6': result = result + "kon"; break;
                    case '7': result = result + "iva"; break;
                    case '8': result = result + "ogi"; break;
                    case '9': result = result + "yan"; break;

                }

            }

            return result;
        }
    }
}
