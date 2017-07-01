using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class AutomaticGear : IGear
    {
        public string Handle()
        {
            return "Automatic gear";
        }
    }
}
