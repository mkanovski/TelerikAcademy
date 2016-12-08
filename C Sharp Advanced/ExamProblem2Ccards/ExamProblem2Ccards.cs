using System;
using System.Text;


namespace ExamProblem2Ccards
{
    class ExamProblem2Ccards
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long[] nums = new long[n];

            for (int i = 0; i < nums.Length ; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }

            string[] hands = new string[n];

            for (int i = 0; i < hands.Length; i++)
            {
                hands[i] = Convert.ToString(nums[i], 2).PadLeft(52,'0');
            }

            int[] deck = new int[52];

            int card = 0;
            int card1 = 0;

            for (int j = 0; j < hands.Length; j++)
            {
                for (int i = 51; i >= 0; i--)
                {
                    card = deck[i];
                    card1 = int.Parse((hands[j][i]).ToString());
                    deck[i] = card + card1;
                }

            }
            int nocard = 0;
            if(Array.IndexOf(deck, nocard) != -1)
            {
                Console.WriteLine("Wa wa!");
            }
            else
            {
                Console.WriteLine("Full deck");
            }

            string[] cardsRepeat = { "As", "Ks", "Qs", "Js", "Ts", "9s", "8s", "7s", "6s", "5s", "4s", "3s", "2s", "Ah", "Kh", "Qh", "Jh", "Th", "9h", "8h", "7h", "6h", "5h", "4h", "3h", "2h", "Ad", "Kd", "Qd", "Jd", "Td", "9d", "8d", "7d", "6d", "5d", "4d", "3d", "2d", "Ac", "Kc", "Qc", "Jc", "Tc", "9c", "8c", "7c", "6c", "5c", "4c", "3c", "2c", };

            for (int i = deck.Length - 1; i >=1 ; i--)
            {
                if (deck[i] % 2 == 1)
                {
                    Console.Write("{0}{1}", cardsRepeat[i], " " );
                }

            }

            if(deck[0] % 2 == 1)
            {
                Console.Write(cardsRepeat[0]);
            }
        }


    }
}
