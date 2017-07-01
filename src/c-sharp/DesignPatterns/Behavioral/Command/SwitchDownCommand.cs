using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class SwitchDownCommand : ICommand
    {
        private Light _light;
        public SwitchDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.TurnOff();
    }
}
