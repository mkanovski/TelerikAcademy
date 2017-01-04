using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeworkPart2
{
    static class PathStorage
    {
        // Saves the Path object to a txt file in the folder of the project
        public static void SavePathToFile(Path path, string fileName)
        {
            File.AppendAllText($"./{fileName}.txt", path.PrintPath());
        }

        // Reads txt file from the project's folder which containt a X,Y,Z values on everyline.
        //Each line creates Point3D object which is inserted in the output Path object.
        public static Path LoadPathFromFIle(string fileLocation)
        {
            Path path = new Path();

            StreamReader readline = new StreamReader($"./{fileLocation}.txt");
            
            do
            {
               string text = readline.ReadLine();
               int[] points = text.Split(',').Select(int.Parse).ToArray();
                path.AddPath(new Point3D(points[0], points[1], points[2]));

            } while (!readline.EndOfStream);

            return path;

        }
    }
}
