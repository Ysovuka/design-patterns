using System;
using Xunit;

namespace DesignPatterns.Structural.Composite.Tests
{
    public class CompositeTests
    {
        [Fact]
        public void CompositePrimitiveTest()
        {
            IComponent component = new CompositeComponent();

            for (int i = 0; i <= 5; i++)
            {
                (component as CompositeComponent).Add(new LeafComponent(i * 5));
            }

            Assert.Equal("0 5 10 15 20 25", component.Traverse());
        }
    }
}
