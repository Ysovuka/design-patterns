using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.Behavioral.Observer
{
    public class ClockTimer : Subject
    {
        public ClockTimer()
        {
            
        }

        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public int Second { get; private set; }

        public void Tick(object state = null)
        {
            Hour = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Second = DateTime.Now.Second;

            Notify();
        }
    }
}
