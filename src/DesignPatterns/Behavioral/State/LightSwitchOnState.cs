using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public sealed class LightSwitchOnState : State<LightSwitch>
    {
        public LightSwitchOnState() { }

        public override void Enter(LightSwitch entity) { }
        public override void Execute(LightSwitch entity)
        {
            entity.ChangeState(LightSwitchOffState.Instance);
        }
        public override void Exit(LightSwitch entity) { }

        private static LightSwitchOnState _instance;
        public static LightSwitchOnState Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LightSwitchOnState();

                return _instance;
            }
        }
    }
}
