using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Memento
{
    public class Light : IMemento
    {
        public Light() { }
        public Light(IMemento memento) { State = memento.State; }

        public bool State { get; private set; }

        public void TurnOn()
        {
            LightMementoTracker.UndoState = new Light(this);
            State = true;
            LightMementoTracker.RedoState = null;
        }
        public void TurnOff()
        {
            LightMementoTracker.UndoState = new Light(this);
            State = false;
            LightMementoTracker.RedoState = null;
        }

        public void Undo()
        {
            if (LightMementoTracker.UndoState != null)
            {
                LightMementoTracker.RedoState = new Light(this);
                this.SetState(LightMementoTracker.UndoState);
                LightMementoTracker.UndoState = null;
            }
        }
        public void Redo()
        {
            if (LightMementoTracker.RedoState != null)
            {
                LightMementoTracker.UndoState = new Light(this);
                this.SetState(LightMementoTracker.RedoState);
                LightMementoTracker.RedoState = null;
            }
        }
        public void SetState(IMemento memento) => this.State = memento.State;

    }
}
