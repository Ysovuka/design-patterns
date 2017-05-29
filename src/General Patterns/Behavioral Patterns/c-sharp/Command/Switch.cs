using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class Switch
    {
        public void Execute(ICommand command) => command.Execute();
    }
}
