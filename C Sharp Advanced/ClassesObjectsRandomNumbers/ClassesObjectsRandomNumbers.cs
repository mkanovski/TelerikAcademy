﻿using System;


namespace ClassesObjectsRandomNumbers
{
    class ClassesObjectsRandomNumbers
    {
        static void Main()
        {

            Random generator = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(generator.Next(100,200));
            }
        }
    }
}
