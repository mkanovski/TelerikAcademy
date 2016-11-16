using System;


namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string array1 = Console.ReadLine();
            string array2 = Console.ReadLine();
            int shorter = 0;
            int check = 0;

            if (array1.Length >= array2.Length)
            {
                shorter = array2.Length;
            }
            else
            {
                shorter = array1.Length;
            }
            for (int i = 0; i < shorter; i++)
            {
                if (array1[i] > array2[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                if (array1[i] < array2[i])
                {
                    Console.WriteLine("<");
                    break;
                }
                if (array1[i] == array2[i])
                {
                    check += 1;
                }
            }
            if (check == shorter && array1.Length > array2.Length)
            {
                Console.WriteLine("<");
            }
            else if (check == shorter && array1.Length < array2.Length)
            {
                Console.WriteLine(">");
            }
            else if (check == shorter && array1.Length == array2.Length)
            {
                Console.WriteLine("=");
            }


        }
    }
}
