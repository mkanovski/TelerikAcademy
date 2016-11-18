using System;

namespace VariableNumberOfArguments
{
    class VariableNumberOfArguments
    {

        static int Product(params int[] numbers) // специалната дума params позволява да слагаме променлив брой променливи
        {
            int product = 1;

            foreach (int n in numbers)
            {
                product *= n;
            }

            return product;
        }

        static void Main()
        {
           int result = Product(2, 100, 54, 37);

            Console.WriteLine(result);
        }
    }
}
