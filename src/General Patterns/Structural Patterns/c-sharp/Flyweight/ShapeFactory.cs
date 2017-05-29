using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class ShapeFactory
    {
        private IDictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

        public int Count => _shapes.Count;

        public IShape GetShape(string shapeName)
        {
            if (!_shapes.ContainsKey(shapeName))
            {
                switch(shapeName)
                {
                    case "Rectangle":
                        IShape rectangle = new Rectangle();
                        _shapes.Add(shapeName, rectangle);
                        return rectangle;
                    case "Circle":
                        IShape circle = new Circle();
                        _shapes.Add(shapeName, circle);
                        return circle;
                    default:
                        throw new NotImplementedException("Factory cannot create the object specified.");
                }
            }

            return _shapes[shapeName];
        }
    }
}
