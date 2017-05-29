using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.Command.Tests
{
    public class ToggleLightOnOff
    {
        [Fact]
        public void Toggle()
        {
            Light lamp = new Light();
            SwitchDownCommand offCommand = new SwitchDownCommand(lamp);
            SwitchUpCommand onCommand = new SwitchUpCommand(lamp);
            Switch lightSwitch = new Switch();

            Assert.False(lamp.IsOn);
            lightSwitch.Execute(onCommand);
            Assert.True(lamp.IsOn);
            lightSwitch.Execute(offCommand);
            Assert.False(lamp.IsOn);
        }
    }
}
