using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class ShapeFacade
    {
        private IShape _circle;
        private IShape _square;

        public ShapeFacade()
        {
            _circle = new Circle();
            _square = new Square();
        }

        public string DrawCircle()
        {
            return $"Drawing {_circle.Draw()}";
        }

        public string DrawSquare()
        {
            return $"Drawing {_square.Draw()}";
        }
    }
}
