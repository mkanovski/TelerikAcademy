using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);

            Console.WriteLine(binary[2]);
        }
    }
}
