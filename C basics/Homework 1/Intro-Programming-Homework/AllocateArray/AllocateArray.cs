using System;


namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] line = new int[n];

            for (int i = 0; i < n; i++)
            {
                line[i] = i * 5;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(line[i]);
            }
        }
    }
}
