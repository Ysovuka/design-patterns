using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.Strategy.Tests
{
    public class CheckAdditionStrategy
    {
        [Fact]
        public void Check()
        {
            MathEquation equation = new MathEquation(new AdditionStrategy());
            Assert.True(equation.Execute(1, 2) == 3);
        }
    }
}
