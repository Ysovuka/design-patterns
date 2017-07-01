using System;
using Xunit;

namespace DesignPatterns.Behavioral.Visitor.Tests
{
    public class VisitorTests
    {
        [Fact]
        public void AcceptVisitors()
        {
            Employees employees = new Employees();
            employees.Attach(new Clerk("Hank", 25000.0, 14));
            employees.Attach(new Director("Elly", 35000.0, 16));
            employees.Attach(new President("Dick", 45000.0, 21));

            Assert.Equal(@"Clerk Hank's new income: $27,500.00
Director Elly's new income: $38,500.00
President Dick's new income: $49,500.00",
employees.Accept(new IncomeVisitor()).Trim());

            Assert.Equal(@"Clerk Hank's new vacation days: 17
Director Elly's new vacation days: 19
President Dick's new vacation days: 24",
            employees.Accept(new VacationVisitor()).Trim());
        }
    }
}
