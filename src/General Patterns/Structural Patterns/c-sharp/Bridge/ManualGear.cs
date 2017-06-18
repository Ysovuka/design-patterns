using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class ManualGear : IGear
    {
        public string Handle()
        {
            return "Manual gear";
        }
    }
}
