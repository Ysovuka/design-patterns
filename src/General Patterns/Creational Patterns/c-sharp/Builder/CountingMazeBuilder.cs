using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class CountingMazeBuilder : MazeBuilder
    {
        public int Doors { get; private set; }
        public int Rooms { get; private set; }

        public override void BuildRoom(int id)
        {
            Rooms++;
        }

        public override void BuildDoor(int entranceRoomId, int exitRoomId)
        {
            Doors++;
        }
    }
}
