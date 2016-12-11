using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblem2CardsPractice
{
    class ExamProblem2CardsPractice
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long[] nums = new long[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }

            long fulldeck = 0;
            long print = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                print = print ^ nums[i];
                fulldeck = fulldeck | nums[i];
            }

            string fulldeckString = Convert.ToString(fulldeck, 2).PadLeft(52, '0');
            string printString = Convert.ToString(print, 2).PadLeft(52, '0');

            string[] cards = { "As", "Ks", "Qs", "Js", "Ts", "9s", "8s", "7s", "6s", "5s", "4s", "3s", "2s",
                               "Ah", "Kh", "Qh", "Jh", "Th", "9h", "8h", "7h", "6h", "5h", "4h", "3h", "2h",
                               "Ad", "Kd", "Qd", "Jd", "Td", "9d", "8d", "7d", "6d", "5d", "4d", "3d", "2d",
                               "Ac", "Kc", "Qc", "Jc", "Tc", "9c", "8c", "7c", "6c", "5c", "4c", "3c", "2c", };

            if (fulldeckString.IndexOf('0') != -1)
            {
                Console.WriteLine("Wa wa!");
            }
            else
            {
                Console.WriteLine("Full deck");
            }

            for (int i = printString.Length - 1; i >= 0; i--)
            {

                if (printString[i] == '1')
                {
                    Console.Write("{0} ", cards[i]);
                }
                
            }

        }
    }
}
