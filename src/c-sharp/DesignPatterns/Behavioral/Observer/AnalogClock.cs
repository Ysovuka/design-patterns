using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class AnalogClock : Observer
    {
        private ClockTimer _timer;

        public AnalogClock(ClockTimer timer)
        {
            _timer = timer;
            _timer.Attach(this);
        }

        ~AnalogClock()
        {
            _timer.Detach(this);
        }

        public override void Update(Subject changedSubject)
        {
            if (changedSubject == _timer)
                Draw();
        }

        public void Draw()
        {
            Snapshot = ($"{_timer.Hour}:{_timer.Minute}:{_timer.Second}");
        }

        public string Snapshot { get; private set; }
    }
}
