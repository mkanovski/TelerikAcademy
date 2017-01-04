using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart2
{
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private static readonly Point3D pointO;

        public static Point3D PointO { get { return pointO; } }

        //CONSTRUCTORS

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //ToString Method
        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }



    }

    
}
