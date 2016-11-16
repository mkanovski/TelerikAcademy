using System;

namespace OddOrEven
{
    class oddOrEven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even " + number );
            }
            else
            {
                Console.WriteLine("odd " + number);
            }
        }
    }
}
