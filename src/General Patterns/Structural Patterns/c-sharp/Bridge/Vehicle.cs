using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class Vehicle : IVehicle
    {
        protected IGear _gear;
        public Vehicle(IGear gear)
        {
            _gear = gear;
        }

        public abstract string AddGear();
    }
}
