using RunPattern;

namespace SomeBasicElemnts
{
    public class WeaponRunner:Run
    {
        public override void RunApp()
        {
            Weapon weapon = new Sword("Armageddon",999999);
            weapon.Kill();
            weapon = new Bone("Kel To Zeth",17005);
            weapon.Kill();
        }
    }
}
