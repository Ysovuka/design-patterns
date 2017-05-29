using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Common.Creational.Maze
{
    public class Wall : IMazeObject
    {
        public Wall() { }
        public Wall(Wall wall) { }

        public Wall Clone() => new Wall(this);
    }
}
