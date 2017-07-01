using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Interpreter
{
    public abstract class Expression
    {
        public void Interpret(Context context)
        {
            while (context.Input.Length != 0)
            {
                if (context.Input.StartsWith(Nine()))
                {
                    context.Output += (9 * Multiplier());
                    SetInputStartIndex(context, 2);
                }
                else if (context.Input.StartsWith(Four()))
                {
                    context.Output += (4 * Multiplier());
                    SetInputStartIndex(context, 1);
                }
                else if (context.Input.StartsWith(Five()))
                {
                    context.Output += (5 * Multiplier());
                    SetInputStartIndex(context, 1);
                }
                else if (context.Input.StartsWith(One()))
                {
                    context.Output += (1 * Multiplier());
                    SetInputStartIndex(context, 1);
                }
                else
                {
                    break;
                }
            }
        }

        public virtual string One() { return " "; }
        public virtual string Four() { return " "; }
        public virtual string Five() { return " "; }
        public virtual string Nine() { return " "; }
        public abstract int Multiplier();

        private void SetInputStartIndex(Context context, int index)
        {
            context.Input = context.Input.Substring(index);
        }
    }
}
