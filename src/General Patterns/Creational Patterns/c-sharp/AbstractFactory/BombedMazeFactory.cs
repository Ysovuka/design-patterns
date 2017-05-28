using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int id) => new BombRoom(id);

        public override Wall MakeWall() => new BombedWall();

    }
}
