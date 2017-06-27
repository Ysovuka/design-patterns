using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MazeFactory
    {
        public virtual Maze MakeMaze() => new Maze();
        public virtual Wall MakeWall() => new Wall();
        public virtual Room MakeRoom(int id) => new Room(id);
        public virtual Door MakeDoor(Room entranceRoom, Room exitRoom) => new Door(entranceRoom, exitRoom);
    }
}
