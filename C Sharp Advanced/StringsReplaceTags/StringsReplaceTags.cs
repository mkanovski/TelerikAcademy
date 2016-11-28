using System;
using System.Text;

namespace StringsReplaceTags
{
    class StringsReplaceTags
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string sub = "";
            string xchange = "";
            StringBuilder url = new StringBuilder();
            StringBuilder text = new StringBuilder();

            while(input.IndexOf("</a>") != -1)
                {

                url.Append(input.Substring(input.IndexOf("=") + 2, input.IndexOf("\">") - input.IndexOf("=") - 2));

                text.Append(input.Substring(input.IndexOf("\">") + 2, input.IndexOf("</a>") - input.IndexOf("\">") - 2));

                sub = input.Substring(input.IndexOf("<a"), input.IndexOf("</a>") - input.IndexOf("<a") + 4);

                xchange = "[" + text + "]" + "(" + url + ")";

                input = input.Replace(sub, xchange);

                url.Clear();
                text.Clear();
            }

            Console.WriteLine(input);

        }
    }
}
