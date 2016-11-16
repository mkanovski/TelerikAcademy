using System;


namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine(((input >> position) & 1) == 0 ? "0" : "1");
        }
    }
}
