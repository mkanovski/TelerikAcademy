using System;

namespace WorkshopBuses
{
    class WorkshopBuses
    {
        static void Main()
        {
            int bus = int.Parse(Console.ReadLine());
            int groups = 0;
            int minimalSpeed = 1501;
            
            for (int i = 1; i <= bus; i++)
            {
                int currentSpeed = int.Parse(Console.ReadLine());
                if (currentSpeed <= minimalSpeed)
                {
                    groups++;
                    minimalSpeed = currentSpeed;
                } 
            }
            Console.WriteLine(groups);
        }
    }
}
