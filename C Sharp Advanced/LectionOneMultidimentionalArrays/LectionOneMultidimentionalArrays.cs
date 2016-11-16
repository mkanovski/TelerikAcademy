using System;

namespace LectionOneMultidimentionalArrays
{
    class LectionOneMultidimentionalArrays
    {
        static void Main()
        {
            // Задачи за изпита видове:
            // 1. Многомерни масиви
            // 2. Едномерни масиви с уловка от C# Advance
            // 3. Побитови операции
            // 4. Стрингове и работа с текст
            // 5. Броични системи

            // Деклариране на двумерен масив (матрица)

            int[,] intMatrix = new int[2, 4]; //2 реда и 4 колони, първо редовете и после колоните

            string[,] stringMatrix = new string[3, 3]; // стринг матрица, двумерен масив

            int[,] intMatrix1 = new int[2, 4]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 }
            };

            string[,] stringMatrix1 = new string[3, 3]
            {
                { "fhdjkfh", "djhfdkjfh", "fjdshf" },
                { "fkjdhf", "fkjsdhf", "fjdkhf" },
                { "fkjdhf", "fkjsdhf", "fjdkhf" }
            };


            int[,,] cube = new int[3, 3, 3]; // триизмерен масив

            int[,,,] fourDimension = new int[3, 3, 3, 3]; // четириизмерен масив

            // Как да принтираме многомерни масиви на конзолата

            string n = stringMatrix1[2, 3]; //Така се взима елемента на ред 2, колона 3

            int n1 = stringMatrix.Length; // връща колко елемента има цялата матрица

            // intMatrix1.GetLenght(индек на реда, който искаме да видим колко е дълъг);

            //Jagged Arrays
            // деклариране

            int[][] jaggedArray = new int[5][]; // назъбен масив с големина 5 масива
        }
    }
}
