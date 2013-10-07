using RunPattern;
using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public class Sword:Weapon
    {
        public Sword(string name, int dmg, IOutputWritter writter) : base(dmg,name, writter)
        {
            Type = new SwordType();
        }

    }
}
