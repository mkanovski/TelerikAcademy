using System;
using System.Numerics; 

namespace ExamProblem1
{
    class ExamProblem1
    {
        static void Main(string[] args)
        {
            string[] numbersString = Console.ReadLine().Split(',');
            for (int i = 0; i < numbersString.Length; i++)
            {
                numbersString[i] = numbersString[i].Trim();
            }

            BigInteger[] numbersDec = Decode(numbersString);

            for (int i = 0; i < numbersDec.Length; i++)
            {
                numbersDec[i] = BigInteger.Parse(AnyToAny(8, numbersDec[i].ToString(), 10));
            }

            BigInteger prod = 1;

            foreach (var num in numbersDec)
            {
                prod *= num;
            }

            Console.WriteLine(prod);
        }

        static BigInteger[] Decode(string[] numbersString)
        {
            BigInteger[] numbersDec = new BigInteger[numbersString.Length];

            string[] digits = { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };

            for (int i = 0; i < numbersString.Length; i++)
            {
                numbersString[i] = numbersString[i].Replace("hristofor", "3");
                numbersString[i] = numbersString[i].Replace("hristo", "0");
                numbersString[i] = numbersString[i].Replace("vladimir", "7");
                numbersString[i] = numbersString[i].Replace("vlad", "4");
                numbersString[i] = numbersString[i].Replace("tosho", "1");
                numbersString[i] = numbersString[i].Replace("pesho", "2");
                numbersString[i] = numbersString[i].Replace("haralampi", "5");
                numbersString[i] = numbersString[i].Replace("zoro", "6");
                
            }

            for (int i = 0; i < numbersString.Length; i++)
            {
                numbersDec[i] = BigInteger.Parse(numbersString[i]);
            }

            return numbersDec;
        }

        static string AnyToAny(int inputBase, string number, int outputBase)
        {
            BigInteger resultDec = 0;

            foreach (char digit in number)
            {
                int digitValue;
                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = digit - 'A' + 10;
                }

                resultDec = resultDec * inputBase + digitValue;
            }

            string result = "";
            do
            {
                BigInteger leftoverNum = 0;

                if ((resultDec % outputBase) % 1 == 0)
                {
                    leftoverNum = resultDec % outputBase;
                }
                else
                {
                    leftoverNum = (resultDec % outputBase) * outputBase;
                }

                string leftover = leftoverNum.ToString();

                switch (leftover)
                {
                    case "0": result = "0" + result; break;
                    case "1": result = "1" + result; break;
                    case "2": result = "2" + result; break;
                    case "3": result = "3" + result; break;
                    case "4": result = "4" + result; break;
                    case "5": result = "5" + result; break;
                    case "6": result = "6" + result; break;
                    case "7": result = "7" + result; break;
                    case "8": result = "8" + result; break;
                    case "9": result = "9" + result; break;
                    case "10": result = "A" + result; break;
                    case "11": result = "B" + result; break;
                    case "12": result = "C" + result; break;
                    case "13": result = "D" + result; break;
                    case "14": result = "E" + result; break;
                    case "15": result = "F" + result; break;
                }

                resultDec /= outputBase;

            } while (resultDec != 0);

            return result;

        }
    }
}
