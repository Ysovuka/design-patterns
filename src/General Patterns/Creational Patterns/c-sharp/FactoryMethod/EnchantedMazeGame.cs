using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Common.Creational.Maze;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        public override Room MakeRoom(int id) => new EnchantedRoom(id, new Spell("Fireball"));
        public override Wall MakeWall() => new EnchantedWall(new Spell("Disembowl"));
    }
}
