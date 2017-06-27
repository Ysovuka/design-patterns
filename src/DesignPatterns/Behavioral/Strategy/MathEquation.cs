using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class MathEquation
    {
        private IStrategy _strategy;

        public MathEquation(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Execute(int left, int right) => _strategy.Execute(left, right);

    }
}
