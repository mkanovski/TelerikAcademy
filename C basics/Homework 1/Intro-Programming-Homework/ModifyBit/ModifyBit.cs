using System;


namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if(v == 0)
            {
                int mask = ~(1 << p);
                int result = (n & mask);
                Console.WriteLine(result);
            }
            else
            {
                int mask1 = 1 << p;
                int result1 = n | mask1;
                Console.WriteLine(result1);
            }

        }
    }
}
