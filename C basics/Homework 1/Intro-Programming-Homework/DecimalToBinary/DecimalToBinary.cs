using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            int dec = int.Parse(Console.ReadLine());
            string result = "";
            int check = dec;

            do
            {
                result = result + (dec % 2 == 0 ? "0" : "1");
                dec = dec / 2;
            } while (dec != 0);

            string final = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                final += result[i];
            }
            Console.WriteLine(final);
            
        }
    }
}
