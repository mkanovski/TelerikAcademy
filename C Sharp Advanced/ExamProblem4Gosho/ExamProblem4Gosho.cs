using System;
using System.Linq;
using System.Text;


namespace ExamProblem4Gosho
{
    class ExamProblem4Gosho
    {
        static void Main()
        {
            string keyword = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            StringBuilder read = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                read.Append(Console.ReadLine());
            }

            char[] chars = { '.', '!' };
		
            string text = read.ToString();

            int indexKey = text.IndexOf(keyword, 0);

            int sentanceStart = text.Substring(0, text.Length - (text.Length - indexKey)).LastIndexOfAny(chars) + 1;
            int sentanceEnd = text.Substring(sentanceStart).IndexOfAny(chars) + 1 + sentanceStart;

            string sentance = text.Substring(sentanceStart, sentanceEnd - sentanceStart);

            string workSentance = ""; 

            if(sentance[sentance.Length-1] == '!')
            {
                workSentance = sentance.Substring(0, sentance.IndexOf(keyword));

            }

            if (sentance[sentance.Length - 1] == '.')
            {
                int start = sentance.IndexOf(keyword) + keyword.Length;
                workSentance = sentance.Substring(start);

            }

            ulong result = 0;

            for (int i = 0; i < workSentance.Length - 1; i++)
            {
                if(workSentance[i] != 32)
                {
                    result = result + (workSentance[i] * (ulong)keyword.Length);
                }
            }

            Console.WriteLine(result);
        }
    }
}
