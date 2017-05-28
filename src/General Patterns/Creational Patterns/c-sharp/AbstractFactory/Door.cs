﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Door : IMazeObject
    {
        public Door(Room entranceRoom, Room exitRoom)
        {
            Entrance = entranceRoom;
            Exit = exitRoom;
        }

        public Room Entrance { get; private set; }
        public Room Exit { get; private set; }
    }
}
