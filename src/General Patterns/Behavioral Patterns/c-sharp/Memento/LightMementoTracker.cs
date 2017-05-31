using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Memento
{
    public static class LightMementoTracker
    {
        public static IMemento UndoState { get; set; }
        public static IMemento RedoState { get; set; }
    }
}
