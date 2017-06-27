using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface IStrategy
    {
        int Execute(int left, int right);
    }
}
