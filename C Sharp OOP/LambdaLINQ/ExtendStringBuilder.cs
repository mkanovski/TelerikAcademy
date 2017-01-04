using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLINQ
{
    //Problem 1: Extend StringBuilder with Substring Method
    public static class ExtendStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int lenght)
        {
            // Remove anything before the start index
            int LenghtRemovedPartAtBeginning = index;
            text.Remove(0, LenghtRemovedPartAtBeginning);

            //Remove anything after the desired lenght
            int StartOfThePartNeedToBeRemoved = lenght;
            int LenghtRemovedPartAtEnd = text.Length - lenght;
            text.Remove(lenght, LenghtRemovedPartAtEnd);

            return text;
        }


    }
}
