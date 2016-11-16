using System;

namespace WorkshopNumberPages
{
    class WorkshopNumberPages
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;

            for (int i = 1; 0 < digits; i++)
            {
                digits = digits - i.ToString().Length;
                pages++;
                
                
                //if (0 < i && i < 10)
                //{
                //    digits -= 1;
                //    pages++;                    
                //}
                //else if (9 < i && i < 100)
                //{
                //    digits -= 2;
                //    pages++;
                //}
                //else if (99 < i && i < 1000)
                //{
                //    digits -= 3;
                //    pages++;
                //}
                //else if (999 < i && i < 10000)
                //{
                //    digits -= 4;
                //    pages++;
                //}
                //else if (9999 < i && i < 100000)
                //{
                //    digits -= 5;
                //    pages++;
                //}
                //else if (99999 < i && i < 1000000)
                //{
                //    digits -= 6;
                //    pages++;
                //}

            }
            Console.WriteLine(pages);
        }
    }
}
