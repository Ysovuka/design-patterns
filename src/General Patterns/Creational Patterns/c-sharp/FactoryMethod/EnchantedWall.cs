using DesignPatterns.Common.Creational.Maze;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class EnchantedWall : Wall
    {
        public EnchantedWall(Spell spell)
        {
            Spell = spell;
        }

        public Spell Spell { get; private set; }
    }
}