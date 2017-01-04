using System;


namespace HomeworkPart1
{
    public class PhoneDisplay
    {
        private readonly double inchSize;
        private readonly int numberOfColors;
        private MobilePhone parent;

        public MobilePhone Parent { get { return parent; } set { parent = value; } }
        public double InchSize { get {return inchSize;} }
        public int NumberOfColors { get { return numberOfColors; } }

        // Empty constructor - sets all fields to their defaul values
        public PhoneDisplay()
        {
            this.inchSize = default(double);
            this.numberOfColors = default(int);
            this.parent = default(MobilePhone);
        }

        // Constructor with all fields optional
        public PhoneDisplay(double inchSize = default(double), int numberOfColors = default(int))
        {
            this.inchSize = inchSize;
            this.numberOfColors = numberOfColors;
        }
    }
}
