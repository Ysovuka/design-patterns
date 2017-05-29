using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public sealed class LightSwitchOffState : State<LightSwitch>
    {
        public LightSwitchOffState() { }

        public override void Enter(LightSwitch entity) { }
        public override void Execute(LightSwitch entity)
        {
            entity.ChangeState(LightSwitchOnState.Instance);
        }
        public override void Exit(LightSwitch entity) { }

        private static LightSwitchOffState _instance;
        public static LightSwitchOffState Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LightSwitchOffState();

                return _instance;
            }
        }
    }
}
