using System;


namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            int l = hex.Length;
            long power = 1;
            long result = 0;


            for (int i = l - 1; i >= 0; i--)
            {
                int number = 0;
                switch (hex[i])
                {
                    case 'A':  number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = hex[i] - '0'; break;
                 }
                result = result + number * power;
                power = power * 16;

            }
            Console.WriteLine(result);
        }
    }
}
