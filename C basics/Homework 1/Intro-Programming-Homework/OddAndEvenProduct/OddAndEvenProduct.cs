using System;


namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');

            long resultOdd = 1;
            long resultEven = 1;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(inputArray[i]);

                if ((i+1) % 2 == 0)
                {
                    resultEven = resultEven * number;
                }
                else
                {
                    resultOdd = resultOdd * number;
                }

             }
            Console.WriteLine(resultEven == resultOdd ? "yes {0}" : "no {0} {1}", resultOdd, resultEven);
        }
    }
}
