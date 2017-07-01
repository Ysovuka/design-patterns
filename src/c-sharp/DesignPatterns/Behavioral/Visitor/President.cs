using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class President : Employee
    {
        public President(string name, double income, int vacationDays)
            : base(name, income, vacationDays) { }
    }
}
