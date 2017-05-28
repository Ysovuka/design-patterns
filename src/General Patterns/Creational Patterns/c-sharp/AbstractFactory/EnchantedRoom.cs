using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class EnchantedRoom : Room
    {
        public EnchantedRoom(int id, Spell spell) : base(id)
        {
            Enchantment = spell;
        }

        public Spell Enchantment { get; private set; }
    }
}
