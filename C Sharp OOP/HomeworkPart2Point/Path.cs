using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart2
{
    public class Path
    {
        private List<Point3D> list1;

        public Path()
        {
            list1 = new List<Point3D>();
        }

        //Method to add Point3D object to Path collection
        public void AddStepToPath(Point3D step)
        {
            this.list1.Add(step);
        }

        //Method to Print each Point3D object from a Path collection 
        public string PrintPath()
        {
            string path = "";

            foreach (var point in this.list1)
            {
                path = path + point.ToString() + "\r\n";
            }

            return path;
        }
    }
}
