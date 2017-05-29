using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Common.Creational.Maze
{
    public class Door : IMazeObject
    {
        public Door() { }

        public Door(Room entranceRoom, Room exitRoom)
        {
            Entrance = entranceRoom;
            Exit = exitRoom;
        }

        public Door(Door door)
        {
            Entrance = door.Entrance;
            Exit = door.Exit;
        }

        public Room Entrance { get; private set; }
        public Room Exit { get; private set; }

        public Door Clone() => new Door(this);
        public void Initialize(Room entrance, Room exit)
        {
            Entrance = entrance;
            Exit = exit;
        }
    }
}
