using System;
using System.Text;
using System.Linq;


namespace StringsExtractSentances
{
    class StringsExtractSentances
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int startIndex = 0;
            int endIndex = text.IndexOf('.', startIndex);

            StringBuilder result = new StringBuilder();

            while (endIndex > 0)
            {
                string tempSentance = text.Substring(startIndex, endIndex - startIndex);

                if ( CheckIfToPrint(tempSentance, word))
                {
                    result.Append(tempSentance.Trim() + ". ");
                }

                startIndex = endIndex + 1;
                endIndex = text.IndexOf('.', startIndex);
            }

            Console.WriteLine(result.ToString().Trim());
            
        }

        static bool CheckIfToPrint(string tempSentance, string word)
        {
            int startIndex = tempSentance.IndexOf(word, 0);
            bool print = false;

            while (startIndex >= 0 && print == false)
            {
                int endIndex = startIndex + word.Length - 1;

                if (startIndex >= 0 || !char.IsLetter(tempSentance[startIndex - 1]) &&
                    endIndex < tempSentance.Length  || !char.IsLetter(tempSentance[endIndex + 1]))
                {
                    print = true;
                }

                startIndex = tempSentance.IndexOf(word, endIndex);
            }; 

            return print;

        }
    }
}
