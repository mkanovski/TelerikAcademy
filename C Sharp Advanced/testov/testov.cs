using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace FindWord
{
    class FindWord
    {
        static void Main(string[] args)
        {
            var hint = new string[]{
    "132", "216", "230", "44", "214", "166", "215", "232", "44", "202", "210",
    "205", "210", "224", "223", "44", "202", "216", "203", "223", "44", "224",
    "206", "210", "223", "44", "215", "225", "214", "203", "222", "166", "213",
    "44", "223", "232", "223", "224", "203", "214", "44", "206", "166", "226",
    "203", "120", "44", "133", "223", "44", "224", "206", "203", "222", "203",
    "44", "166", "215", "44", "166", "220", "220", "222", "216", "220", "222",
    "210", "166", "224", "203", "44", "200", "225", "210", "213", "224", "63",
    "210", "215", "44", "204", "225", "215", "201", "224", "210", "216", "215",
    "166", "213", "210", "224", "232", "120", "16", "13", "146", "224", "222",
    "210", "215", "205", "64", "145", "203", "220", "213", "166", "201", "203",
    "44", "201", "166", "215", "44", "223", "210", "214", "220", "213", "210",
    "204", "232", "44", "224", "206", "210", "215", "205", "223", "44", "166",
    "44", "213", "216", "224", "62", "44", "211", "225", "223", "224", "44",
    "200", "203", "44", "201", "166", "222", "203", "204", "225", "213", "44",
    "210", "215", "44", "230", "206", "166", "224", "44", "216", "222", "202",
    "203", "222", "44", "232", "216", "225", "44", "222", "203", "220", "213",
    "166", "201", "203", "16", "13", "150", "206", "210", "215", "212", "44",
    "166", "200", "216", "225", "224", "44", "224", "206", "203", "44", "202",
    "166", "224", "166", "44", "224", "232", "220", "203", "223", "44", "216",
    "204", "44", "224", "206", "203", "44", "224", "206", "222", "203", "203",
    "44", "215", "225", "214", "200", "203", "222", "223", "44", "166", "215",
    "202", "44", "224", "206", "203", "44", "222", "203", "223", "225", "213",
    "224", "44", "63", "44", "206", "216", "230", "44", "214", "225", "201",
    "206", "44", "210", "223", "44", "101", "163", "103", "66", "44", "60",
    "44", "101", "163", "103", "66", "44", "60", "44", "101", "163", "103",
    "66", "44", "60", "44", "101", "163", "103", "66", "120"
};

            int[] dec = new int[hint.Length];

            for (int i = 0; i < hint.Length; i++)
            {
                dec[i] = int.Parse(AnyToAny(7, hint[i], 10));
            }

            char[] chars = new char[dec.Length];

            for (int i = 0; i < dec.Length; i++)
            {
                chars[i] = (char)dec[i];
            }

            Console.WriteLine(new string(chars));
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