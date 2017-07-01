using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Structural.Adapter.Tests
{
    public class DrawLegacyRectangle
    {
        [Fact]
        public void Draw()
        {
            IRectangle rectangle = new RectangleAdapter(120, 200, 60, 40);
            Assert.Equal("(120,200) => (180,240)", rectangle.Draw());
        }
    }
}
