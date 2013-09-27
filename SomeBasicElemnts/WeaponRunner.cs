using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
