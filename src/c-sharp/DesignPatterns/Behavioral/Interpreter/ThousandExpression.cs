using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class ThousandExpression : Expression
    {
        public override string One() { return "M"; }
        public override int Multiplier() { return 1000; }
    }
}
