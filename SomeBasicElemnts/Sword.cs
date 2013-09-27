using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public class Sword:Weapon
    {
        public Sword(string name, int dmg) : base(dmg,name)
        {
            Type = new SwordType();
        }

    }
}
