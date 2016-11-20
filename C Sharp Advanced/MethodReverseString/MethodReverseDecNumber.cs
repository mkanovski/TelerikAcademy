using System;

namespace MethodReverseDecNumber
{
    class MethodReverseDecNumber
    {
        static void Main()
        {
            Console.WriteLine(ReverseDecNumber(decimal.Parse(Console.ReadLine())));
        }


        static decimal ReverseDecNumber(decimal n)
        {
            string number = n.ToString();
            char[] revArray = number.ToCharArray();
            Array.Reverse(revArray);
            string stringResult = new string(revArray);
            decimal result = decimal.Parse(stringResult);
            return result;
        }
    }
}
