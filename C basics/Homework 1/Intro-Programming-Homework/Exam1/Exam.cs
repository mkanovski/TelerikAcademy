using System;

namespace ExamProblem1
{
    class ExamProblem1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = n / 100;
            int secondDigit = (n % 100) / 10;
            int thirdDigit = (n % 100) % 10;

            if (thirdDigit == 0)
            {
                Console.WriteLine("{0:0.00}", ((double)secondDigit * firstDigit));
            }
            else if (thirdDigit > 0 && 5 >= thirdDigit)
            {
                Console.WriteLine("{0:0.00}", (((double)secondDigit * firstDigit) / thirdDigit));
            }
            else
            {
                Console.WriteLine("{0:0.00}", (((double)firstDigit + secondDigit) * thirdDigit));
            }
        }
    }
}