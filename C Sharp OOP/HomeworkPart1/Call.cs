using System;

namespace HomeworkPart1
{
    public class Call
    {
        private readonly DateTime dateOfCall = default(DateTime);
        private readonly DateTime timeOfCall = default(DateTime);
        private readonly string dialedNumber = default(string);
        private readonly int durationOfCall = default(int);

        public DateTime DateOfCall { get { return dateOfCall; } }
        public DateTime TimeOfCall { get { return timeOfCall; } }
        public string DialedNumber { get { return dialedNumber; } }
        public int DurationOfCall { get { return durationOfCall; } }

        public Call(int durationOfCallInSeconds)
        {
            this.durationOfCall = durationOfCallInSeconds;
        }

        public Call(int durationOfCallInSeconds = 0, string dialedNumber = default(string), DateTime dateOfCall = default(DateTime), DateTime timeOfCall = default(DateTime))
        {
            this.durationOfCall = durationOfCallInSeconds;
            this.dialedNumber = dialedNumber;
            this.dateOfCall = dateOfCall;
            this.timeOfCall = timeOfCall;
        }


    }
}
