using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double a = int.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine(sum);
        }
    }
}
