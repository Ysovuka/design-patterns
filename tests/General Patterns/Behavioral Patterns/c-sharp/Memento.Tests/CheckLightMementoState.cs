using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Behavioral.Memento.Tests
{
    public class CheckLightMementoState
    {
        [Fact]
        public void Check()
        {
            Light light = new Light();
            Assert.False(light.State);

            light.TurnOn();
            Assert.True(light.State);
            Assert.True(LightMementoTracker.UndoState != null);

            light.Undo();
            Assert.False(light.State);
            Assert.True(LightMementoTracker.RedoState != null);
            Assert.True(LightMementoTracker.UndoState == null);

            light.Redo();
            Assert.True(light.State);
            Assert.True(LightMementoTracker.RedoState == null);
            Assert.True(LightMementoTracker.UndoState != null);
        }
    }
}
