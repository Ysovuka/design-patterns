using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class EnchantedFactory : MazeFactory
    {
        public override Room MakeRoom(int id) => new EnchantedRoom(id, new Spell("Fireball"));
        public override Door MakeDoor(Room entranceRoom, Room exitRoom) => new EnchantedDoor(entranceRoom, exitRoom, new Spell("Disembowl"));
    }
}
