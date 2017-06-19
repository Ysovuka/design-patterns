using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class Circle : IShape
    {
        public string Draw()
        {
            return "Circle";
        }
    }
}
