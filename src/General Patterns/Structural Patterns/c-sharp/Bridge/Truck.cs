using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Truck : Vehicle
    {
        public Truck(IGear gear) : base(gear) { }

        public override string AddGear()
        {
            return $"Truck handles {_gear.Handle()}";
        }
    }
}
