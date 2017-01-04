using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LambdaLINQ
{
    //Problem 7: Using delegates write a class Timer that can execute certain method at each t seconds.
    public class Delegates
    {
        private Timer clock;
        public int interval;

        public delegate void Problem7Delegate();
        Problem7Delegate Methods = TestMethod;

        public event EventHandler IntervalPassed;
                
        public Delegates(int secondsInterval)
        {
            this.interval = secondsInterval;
            StartTheClock();

        }

        

        public void StartTheClock()
        {
            clock = new Timer(this.interval * 1000);
            clock.Start();
        }

        public static void TestMethod()
        {
            Console.WriteLine("Hello");
        }


    }
}
