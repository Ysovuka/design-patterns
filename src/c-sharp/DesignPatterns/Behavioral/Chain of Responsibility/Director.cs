using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Director : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                return $"{GetType().Name} approved request #{purchase.Number}";
            }
            else if(Successor != null)
            {
                return Successor.ProcessRequest(purchase);
            }

            return $"Unable to make a decision on request #{purchase.Number}";
        }
    }
}
