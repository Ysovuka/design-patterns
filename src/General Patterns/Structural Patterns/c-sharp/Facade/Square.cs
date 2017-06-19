using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class Square : IShape
    {
        public string Draw()
        {
            return "Square";
        }
    }
}
