using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLINQ
{
    // Problem 17: Write a program to return the string with maximum length from an array of strings.
    public class LongestString
    {
        public static string FindLongestString(string[] array)
        {
            string longest = array.Where(s => s.Length == array.Max(x => x.Length)).First();

            return longest;
        }
    }
}
