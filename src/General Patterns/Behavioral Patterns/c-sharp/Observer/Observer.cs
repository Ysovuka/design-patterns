using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Observer
    {
        public abstract void Update(Subject changedSubject);
    }
}
