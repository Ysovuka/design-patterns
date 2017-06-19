using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class CompositeComponent : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();

        public void Add(IComponent component)
        {
            if (!_children.Contains(component))
                _children.Add(component);
        }

        public string Traverse()
        {
            StringBuilder builder = new StringBuilder();

            foreach (IComponent child in _children)
                builder.Append(child.Traverse());

            return builder.ToString().Trim();
        }
    }
}
