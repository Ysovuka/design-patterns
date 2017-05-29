using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class Light
    {
        public bool IsOn { get; set; } = false;

        public Light() { }

        public void TurnOn() => IsOn = true;

        public void TurnOff() => IsOn = false;

    }
}
