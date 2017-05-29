using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Structural.Flyweight.Tests
{
    public class CreateShapes
    {
        [Fact]
        public void Create()
        {
            ShapeFactory factory = new ShapeFactory();

            IShape rectangle = factory.GetShape("Rectangle");
            IShape rectangle2 = factory.GetShape("Rectangle");
            Assert.True(rectangle.Id == rectangle2.Id);

            IShape circle = factory.GetShape("Circle");
            IShape circle2 = factory.GetShape("Circle");
            Assert.True(circle.Id == circle2.Id);

            Assert.False(rectangle.Id == circle.Id);
            Assert.True(factory.Count == 2);
        }
    }
}
