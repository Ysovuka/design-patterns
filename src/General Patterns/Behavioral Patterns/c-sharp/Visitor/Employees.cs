using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public string Accept(IVisitor visitor)
        {
            StringBuilder builder = new StringBuilder();
            foreach(Employee e in _employees)
            {
                builder.AppendLine(e.Accept(visitor));
            }

            return builder.ToString();
        }
    }
}
