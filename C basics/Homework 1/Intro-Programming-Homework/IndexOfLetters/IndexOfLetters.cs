using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (word[i] == alpha[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
