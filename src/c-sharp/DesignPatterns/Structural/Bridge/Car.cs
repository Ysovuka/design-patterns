using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Car : Vehicle
    {
        public Car(IGear gear) : base(gear) { }

        public override string AddGear()
        {
            return $"Car handles {_gear.Handle()}";
        }
    }
}
