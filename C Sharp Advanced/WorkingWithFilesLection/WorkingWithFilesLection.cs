using System;
using System.IO;

namespace WorkingWithFilesLection
{
    class WorkingWithFilesLection
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("TODO-List.txt");

            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            reader.Close();

            // StringReader Stream

            StringReader stringRead = new StringReader("string");

            // Работа със файлове

            var content = File.ReadAllText("TODO-List.text");  // Това има много класове за използване на файлове

            // WriteStream

            StreamWriter writer = new StreamWriter("TODO-List1.text");
        }
    }
}
