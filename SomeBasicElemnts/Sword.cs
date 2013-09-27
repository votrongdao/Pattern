using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public class Sword:Weapon
    {
        public override int Damage { get; set; }

        public Sword()
        {
            Type = new SwordType();
        }

    }
}
