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

            string code = "4a4c6b";

            Console.WriteLine(Encode(code));






        }

        static string Encode(string code)
        {

            string codeResult = "";
            for (int i = 0; i < code.Length; i++)
            {
                string curRep = "";

                while (char.IsNumber(code[i]))
                {
                    curRep += code[i];
                    i++;
                }
                if (curRep == "")
                {
                    curRep = "1";
                }

                codeResult = codeResult + new string(code[i], int.Parse(curRep));
            }


            return codeResult;
        }
    }
}