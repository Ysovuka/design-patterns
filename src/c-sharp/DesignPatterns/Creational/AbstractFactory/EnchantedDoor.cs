using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class EnchantedDoor : Door
    {
        public EnchantedDoor(Room entranceRoom, Room exitRoom, Spell spell) : base(entranceRoom, exitRoom)
        {
            Enchantment = spell;
        }

        public Spell Enchantment { get; private set; }
    }
}
