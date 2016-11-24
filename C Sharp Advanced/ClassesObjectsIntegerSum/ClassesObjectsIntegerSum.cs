using System;
using System.Linq;

namespace ClassesObjectsIntegerSum
{
    class ClassesObjectsIntegerSum
    {
        static void Main()
        {

            Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).ToArray().Sum());
        }
    }
}
