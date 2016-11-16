using System;


namespace GCD
{
    class GCD
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] two = numbers.Split(' ');

            int number1 = int.Parse(two[0]);
            int number2 = int.Parse(two[1]);
            int gcs = 0;

            do
            {
                if (number1 > number2)
                {
                    number1 = number1 - number2;
                }
                else if (number1 == number2)
                {
                    break;
                }
                else
                {
                    number2 = number2 - number1;
                }
            } while (number1 != number2);
            Console.WriteLine(number1);
        }
    }
}
