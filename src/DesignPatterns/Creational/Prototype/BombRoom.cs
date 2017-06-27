using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class BombRoom : Room
    {
        public BombRoom() { }
        public BombRoom(int id) : base(id)
        {
        }

        public BombRoom(BombRoom room)
        {
            base.Sides = room.Sides;
        }

        public override Room Clone() => new BombRoom(this);
    }
}
