using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLINQ
{
    public class Method
    {
        // Problem 6: prints from given array of integers all numbers that are divisible by 7 and 3
        public static void PrintIntsDevidableBy3And7(int[] array)
        {
            var result = array.Where(x => (x != 0) && (x % 3 == 0 || x % 7 == 0)).Select(x => x).ToArray();

            Console.WriteLine(string.Join(", ", result));

        }
    }
    
}
