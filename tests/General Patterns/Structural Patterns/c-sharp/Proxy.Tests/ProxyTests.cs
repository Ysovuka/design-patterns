using System;
using Xunit;

namespace DesignPatterns.Structural.Proxy.Tests
{
    public class ProxyTests
    {
        [Fact]
        public void CheckLoadStatus()
        {
            IImage image = new ProxyImage("test_image");
            Assert.Equal("Loaded test_image Drawing test_image", image.Draw());
        }

        [Fact]
        public void CheckDrawStatus()
        {
            IImage image = new ProxyImage("test_image");
            image.Draw();
            Assert.Equal("Drawing test_image", image.Draw());
        }
    }
}
