using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        string Visit(IElement element);
    }
}
