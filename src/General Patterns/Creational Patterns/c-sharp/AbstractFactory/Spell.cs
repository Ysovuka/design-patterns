using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Spell
    {
        public Spell(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
