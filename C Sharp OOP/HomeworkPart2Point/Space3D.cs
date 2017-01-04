using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart2
{
    static class Space3D
    {
        public static double Distance(Point3D point1, Point3D point2)
        {
            double distance = 0;

            // Formula to find distance between two points in 3D Space 
            double xPow = Math.Pow((point1.X - point2.X), 2);
            double yPow = Math.Pow((point1.Y - point2.Y), 2);
            double zPow = Math.Pow((point1.Z - point2.Z), 2);

            distance = Math.Sqrt(xPow + yPow + zPow);

            //Rounding of the distance to 0.00 format
            distance = Math.Round(distance, 2);

            return distance;
        }
    }
}
