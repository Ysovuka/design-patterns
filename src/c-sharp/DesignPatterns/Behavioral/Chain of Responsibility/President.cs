using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class President : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                return $"{GetType().Name} approved request #{purchase.Number}";
            }
            else
            {
                return $"Request #{purchase.Number} requires an executive meeting!";
            }
        }
    }
}
