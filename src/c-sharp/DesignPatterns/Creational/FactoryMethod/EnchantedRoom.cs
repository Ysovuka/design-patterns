using DesignPatterns.Common.Creational.Maze;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class EnchantedRoom : Room
    {
        public EnchantedRoom(int id, Spell spell) : base(id)
        {
            Spell = spell;
        }

        public Spell Spell { get; private set; }
    }
}