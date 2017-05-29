using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class Circle : IShape
    {
        public Circle() { }

        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}
