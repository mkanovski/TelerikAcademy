using System;
using System.Collections.Generic;
using System.Text;


namespace WorkshopMagicWords
{
    class WorkshopMagicWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            words = Reorder(words, n);

            Console.WriteLine(Print(words));

        }

        static string[] Reorder(string[] words, int n)
        {
            int newPos = 0;
            string elementToMove = "";
            
            List<string> rewords = new List<string>(words);

            rewords.Add(string.Empty);

            for (int i = 0; i < rewords.Count; i++)
            {
                newPos = rewords[i].Length % (n + 1);

                elementToMove = rewords[i];

                rewords.RemoveAt(i);

                rewords.Insert(newPos, elementToMove);

                
            }
            
            string[] wordsFinal = rewords.ToArray();

            return wordsFinal;
        }

        static string Print(string[] words)
        {

            string[] lenght = new string[words.Length];

            words.CopyTo(lenght, 0);

            Array.Sort(lenght, (x, y) => x.Length.CompareTo(y.Length));

            int iterations = lenght[lenght.Length - 1].Length;
            
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Length > i)
                    {
                        output.Append(words[j][i]);
                    }
                }
            }

            return output.ToString();
        }
    }
}
