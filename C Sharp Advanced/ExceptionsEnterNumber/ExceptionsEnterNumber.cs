using System;

namespace ExceptionsEnterNumber
{
    class ExceptionsEnterNumber
    {
        static void Main()
        {
            int start = 1;
            int end = 100;

            EnterNumber(start, end);
        }

        static void EnterNumber(int start, int end)
        {
            int input;
            int[] number = new int[12];
            number[0] = start;
            number[11] = end;

            for (int i = 1; i < 11; i++)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());

                    if (input <= number[i-1])
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        number[i] = input;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Exception");
                    return;
                }
            }
            
            for (int i = 0; i < number.Length - 1; i++)
            {
                Console.Write("{0} < ", number[i]);
            }
            Console.Write(number[11]);
        }
    }
}
