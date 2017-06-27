using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class LeafComponent : IComponent
    {
        private int _value;
        public LeafComponent(int value)
        {
            _value = value;
        }
        public string Traverse()
        {
            return $"{_value} ";
        }
    }
}
