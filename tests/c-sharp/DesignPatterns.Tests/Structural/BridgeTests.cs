using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Structural.Bridge.Tests
{
    public class AutomaticGearTests
    {
        [Fact]
        public void CheckCarAutomaticGear()
        {
            IVehicle vehicle = new Car(new AutomaticGear());
            Assert.Equal("Car handles Automatic gear", vehicle.AddGear());
        }

        [Fact]
        public void CheckTruckAutomaticGear()
        {
            IVehicle vehicle = new Truck(new AutomaticGear());
            Assert.Equal("Truck handles Automatic gear", vehicle.AddGear());
        }
    }

    public class ManualGearTests
    {
        [Fact]
        public void CheckCarManualGear()
        {
            IVehicle vehicle = new Car(new ManualGear());
            Assert.Equal("Car handles Manual gear", vehicle.AddGear());
        }

        [Fact]
        public void CheckTruckManualGear()
        {
            IVehicle vehicle = new Truck(new ManualGear());
            Assert.Equal("Truck handles Manual gear", vehicle.AddGear());
        }
    }
}
