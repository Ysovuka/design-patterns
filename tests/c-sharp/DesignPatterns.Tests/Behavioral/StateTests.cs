using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.State.Tests
{
    public class CheckLightSwitch
    {
        [Fact]
        public void Check()
        {
            LightSwitch lightSwitch = new LightSwitch();
            Assert.True(lightSwitch.State == LightSwitchOffState.Instance);

            lightSwitch.Toggle();
            Assert.True(lightSwitch.State == LightSwitchOnState.Instance);

            lightSwitch.Toggle();
            Assert.True(lightSwitch.State == LightSwitchOffState.Instance);
        }
    }
}
