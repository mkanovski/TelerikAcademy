using System;


namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal k = decimal.Parse(Console.ReadLine());
            decimal result = 1;
            decimal x = n - k;

         while (x != 0)
            {
                result = result * n;
                n--;
                x--;
                
            }
            Console.WriteLine(result);
        }
    }
}
