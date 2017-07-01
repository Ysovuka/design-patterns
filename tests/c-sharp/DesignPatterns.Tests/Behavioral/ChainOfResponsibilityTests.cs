using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Tests
{
    public class ChainOfResponsibilityTests
    {
        [Fact]
        public void MakeDecision()
        {
            Approver director = new Director();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Purchase p2034 = new Purchase(2034, 350.00, "Assets");
            Assert.Equal("Director approved request #2034", director.ProcessRequest(p2034));

            Purchase p2035 = new Purchase(2035, 15000.00, "Project X");
            Assert.Equal("VicePresident approved request #2035", director.ProcessRequest(p2035));

            Purchase p2036 = new Purchase(2036, 150000.00, "Project Y");
            Assert.Equal("Request #2036 requires an executive meeting!", director.ProcessRequest(p2036));
        }
    }
}
