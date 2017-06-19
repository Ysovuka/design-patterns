using System;
using Xunit;

namespace DesignPatterns.Structural.Facade.Tests
{
    public class FacadeTests
    {
        [Fact]
        public void DrawCircle()
        {
            ShapeFacade shape = new ShapeFacade();
            Assert.Equal("Drawing Circle", shape.DrawCircle());
        }

        [Fact]
        public void DrawSquare()
        {
            ShapeFacade shape = new ShapeFacade();
            Assert.Equal("Drawing Square", shape.DrawSquare());
        }
    }
}
