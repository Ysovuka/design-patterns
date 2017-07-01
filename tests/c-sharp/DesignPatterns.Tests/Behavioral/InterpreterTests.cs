using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.Interpreter.Tests
{
    public class InterpreterTests
    {
        [Fact]
        public void InterpretRomanNumerals()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach(Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Assert.Equal(1928, context.Output);
        }
    }
}
