using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class VacationVisitor : IVisitor
    {
        public string Visit(IElement element)
        {
            Employee employee = element as Employee;

            employee.VacationDays += 3;

            return $"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}";
        }
    }
}
