using System;

namespace Methods
{
    class Methods
    {
        static void Main()
        {
            

        }

        // Дефиниране на Метод
        static void Print(string text) // static - е типът на метода ( static значи, че се вика през клас)
                                       // void е вида на информацията която връща - void не връща нищо. Може да е int, string и тн.
                                       // Print е името на метода. Винаги се пише с главна буква.
                                       // () вида информация, която ще се подава към метода.
        {
            Console.WriteLine(text);
        }

        // Дефиниране на различни променливи в един Метод
        static void PrintMultiple(string text, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(text);
            }
        }

        // Array.IndexOf - даваме му масив и елемент, връща индекса, на който първо е срещтнал този елемент

        static int IndexOf(char[] symbols, char seekedValue)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if(symbols[i] == seekedValue)
                {
                    return i;
                }
            }

            return -1;
        }


        

    }
}
