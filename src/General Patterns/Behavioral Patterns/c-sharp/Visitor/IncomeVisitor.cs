using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class IncomeVisitor : IVisitor
    {
        public string Visit(IElement element)
        {
            Employee employee = element as Employee;

            employee.Income *= 1.10;

            return $"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income.ToString("C")}";
        }
    }
}
