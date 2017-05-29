using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class AdditionStrategy : IStrategy
    {
        public AdditionStrategy() { }

        public int Execute(int left, int right) => left + right;
    }
}
