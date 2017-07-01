using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.Singleton.Tests
{
    public class CreateSingletonInstance
    {
        [Fact]
        public void Create()
        {
            SingletonInstance instance = SingletonInstance.Instance("Instance 1");
            Assert.NotNull(instance);

            SingletonInstance instance2 = SingletonInstance.Instance("Instance 2");
            Assert.NotEqual("Instance 2", instance2.InstanceName);
        }
    }
}