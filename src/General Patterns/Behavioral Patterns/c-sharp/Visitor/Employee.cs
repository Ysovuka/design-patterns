using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Employee : IElement
    {
        public Employee(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        public string Name { get; set; }
        public double Income { get; set; }
        public int VacationDays { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
