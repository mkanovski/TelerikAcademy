using System;
using System.Text;


namespace StringCorrectCrackets
{
    class StringCorrectCrackets
    {
        static void Main()
        {

            string text = Console.ReadLine();

            int check = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '(')
                {
                    check++;
                }
                else if(text[i] == ')')
                {
                    check--;
                }

                if(check < 0)
                {
                    Console.WriteLine("Incorrect");
                    break;
                }

            }

            if (check == 0)
            {
                Console.WriteLine("Correct");
            }
            else if (check > 0)
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
