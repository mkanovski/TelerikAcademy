using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("TEST FOR MOBILEPHONE (GSM) CLASS");
            Console.WriteLine();
            MobilePhoneTEST.GSMTest();
            Console.WriteLine();
            Console.WriteLine("TEST FOR CALCULATE PRICE CLASS");
            Console.WriteLine();
            MobilePhoneTEST.GSMCallHistoryTest(0.40);        
        }
    }
}
