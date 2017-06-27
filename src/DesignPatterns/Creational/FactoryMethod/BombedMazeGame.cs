using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Common.Creational.Maze;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class BombedMazeGame : MazeGame
    {
        public override Room MakeRoom(int id) => new BombRoom(id);
        public override Wall MakeWall() => new BombedWall();
    }
}
