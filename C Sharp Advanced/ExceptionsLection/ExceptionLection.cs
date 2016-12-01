using System;

namespace ExceptionsLection
{
    class ExceptionLection
    {
        static void Main()
        {

            try
            {
                int age = int.Parse(Console.ReadLine());
            }
            catch (FormatException) // Тук се дефинира какъв ексепшън искаме да хванем. Без дефиниция хваща всичко
            {

                Console.WriteLine("Invalid age");
            }
        }
    }
}
