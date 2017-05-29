using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.Strategy.Tests
{
    public class CheckSubtractionStrategy
    {
        [Fact]
        public void Check()
        {
            MathEquation equation = new MathEquation(new SubtractionStrategy());
            Assert.True(equation.Execute(2, 1) == 1);
        }
    }
}
