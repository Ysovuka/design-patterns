using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public class LightSwitch
    {
        public LightSwitch() { ChangeState(LightSwitchOffState.Instance); }
        public State.State<LightSwitch> State { get; set; }
        
        public void ChangeState(State<LightSwitch> nextState)
        {
            if (State == nextState) throw new InvalidOperationException("Already in that state.");

            State?.Exit(this);

            State = nextState;

            State?.Enter(this);
        }

        public void Toggle()
        {
            State.Execute(this);
        }
    }
}
