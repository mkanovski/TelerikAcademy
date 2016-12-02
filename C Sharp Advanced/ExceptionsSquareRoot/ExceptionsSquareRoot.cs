using System;

namespace ExceptionsSquareRoot
{
    class ExceptionsSquareRoot
    {
        static void Main()
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if(input >= 0)
                {
                    Console.WriteLine("{0:0.000}", Math.Sqrt(input));
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
                
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
