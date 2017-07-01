using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class SubtractionStrategy : IStrategy
    {
        public SubtractionStrategy() { }

        public int Execute(int left, int right) => left - right;
    }
}
