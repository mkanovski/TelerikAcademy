using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart2List
{
    // Sample class to show the functionality of the Version Attribute
    [Version (10, 5)]
    public class SampleClass
    {
        //Everytime the class is created the version is printed at runtime
        public SampleClass()
        {
            VersionAttribute.PrintVersion();
        }
    }

    //Defining the attribute which will hold the version
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    class VersionAttribute : Attribute
    {
        public static int majorVersion;
        public static int minorVersion;

        public static void PrintVersion()
        {
            Console.WriteLine($"Version: {majorVersion}.{minorVersion}");
        }

        public VersionAttribute()
        {
            PrintVersion();
        }

        public VersionAttribute(int major, int minor)
        {
            majorVersion = major;
            minorVersion = minor;
            PrintVersion();
        }
    }
}
