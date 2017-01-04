using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLINQ
{
    class Program
    {
        static void Main()
        {
            string[] array = new string[] { "1", "22", "55555", "333", "4444", "66666" };

            Console.WriteLine(LongestString.FindLongestString(array));
            

            
        }
    }
}
