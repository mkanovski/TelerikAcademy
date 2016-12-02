using System;


namespace WorkshopStrings
{
    class WorkshopStrings
    {
        static void Main()
        {
            string code = Console.ReadLine();

            int sizeCypher = Devide(code);

            code = code.Remove((code.Length - sizeCypher.ToString().Length));

            code = Encode(code);

            string cypher = code.Substring(code.Length - sizeCypher, sizeCypher);

            string codeFinal = code.Remove(code.Length - cypher.Length);

            string result = Decrypt(codeFinal, cypher);

            Console.WriteLine(result);
        }

        static string Decrypt(string text, string cypher)
        {
            char[] code = text.ToCharArray();

            int lenght = Math.Max(text.Length, cypher.Length);

            for (int i = 0; i < lenght; i++)
            {
                int result = 0;
                result = (code[i % code.Length] - 'A') ^ (cypher[i % cypher.Length] - 'A');

                code[i % code.Length] = (char)(result + 'A');

            }           

            return new string(code);

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

        static int Devide(string code)
        {
            int c = code.Length - 1;
            string lenght = "";

            while (char.IsNumber(code[c]))
            {
                lenght = code[c] + lenght;
                c--;
            }

            int size = int.Parse(lenght);

            code = code.Replace(lenght, "");

            return size;
        }
    }
}
