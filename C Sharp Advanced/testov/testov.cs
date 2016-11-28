using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FindWord
{
    class FindWord
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int startIndex = 0;
            int endIndex = text.IndexOf('.');

            StringBuilder result = new StringBuilder();

            string temp;

            while (endIndex > 0)
            {
                temp = text.Substring(startIndex, endIndex - startIndex);

                if (chechPrint(temp.Trim(), word))
                {
                    result.Append(temp.Trim());
                    result.Append(". ");
                }

                startIndex = endIndex + 1;
                endIndex = text.IndexOf('.', startIndex);
            }
            Console.WriteLine(result.ToString().Trim());
        }

        static bool chechPrint(string temp, string word)
        {
            int subStart = temp.IndexOf(word, 0);
            bool print = false;
            int checkStartIndex;
            int checkEndIndex;
            while (subStart >= 0 && print == false)
            {
                checkStartIndex = subStart - 1;
                checkEndIndex = subStart + word.Length;
                if (
                    (checkStartIndex < 0 || !char.IsLetter(temp[checkStartIndex])) &&
                    (checkEndIndex >= temp.Length || !char.IsLetter(temp[checkEndIndex]))
                    )
                {
                    print = true;
                }
                subStart = temp.IndexOf(word, checkEndIndex);
            }
            return print;
        }
    }
}