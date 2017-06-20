using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Clerk : Employee
    {
        public Clerk(string name, double income, int vacationDays) 
            : base(name, income, vacationDays) { }

    }
}
