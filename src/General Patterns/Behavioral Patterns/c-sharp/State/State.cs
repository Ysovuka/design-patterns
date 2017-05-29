using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public abstract class State<TEntityType> where TEntityType : class
    {
        public abstract void Enter(TEntityType entity);
        public abstract void Execute(TEntityType entity);
        public abstract void Exit(TEntityType entity);
    }
}
