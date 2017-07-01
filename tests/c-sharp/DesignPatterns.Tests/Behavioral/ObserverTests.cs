using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.Observer.Tests
{
    public class CreateAnalogClock
    {
        [Fact]
        public void Create()
        {
            ClockTimer timer = new ClockTimer();
            AnalogClock clock = new AnalogClock(timer);

            timer.Tick();
            Assert.True(clock.Snapshot == $"{timer.Hour}:{timer.Minute}:{timer.Second}");
        }
    }

    public class CreateDigitalClock
    {
        [Fact]
        public void Create()
        {
            ClockTimer timer = new ClockTimer();
            DigitalClock clock = new DigitalClock(timer);

            timer.Tick();
            Assert.True(clock.Snapshot == $"{timer.Hour}:{timer.Minute}");
        }
    }
}
