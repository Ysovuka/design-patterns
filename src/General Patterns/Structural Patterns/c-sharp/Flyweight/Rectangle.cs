using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class Rectangle : IShape
    {
        public Rectangle() { }

        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}
