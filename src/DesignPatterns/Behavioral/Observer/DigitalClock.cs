using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class DigitalClock : Observer
    {
        private ClockTimer _timer;

        public DigitalClock(ClockTimer timer)
        {
            _timer = timer;
            _timer.Attach(this);
        }

        ~DigitalClock()
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
            Snapshot = ($"{_timer.Hour}:{_timer.Minute}");
        }

        public string Snapshot { get; private set; }
    }
}
