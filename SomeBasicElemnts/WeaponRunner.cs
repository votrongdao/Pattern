using RunPattern;

namespace SomeBasicElemnts
{
    public class WeaponRunner:Run
    {
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();

            Weapon weapon = new Sword("Armageddon",999999, writter);
            weapon.Kill();
            weapon = new Bone("Kel To Zeth",17005, writter);
            weapon.Kill();
        }
    }
}
