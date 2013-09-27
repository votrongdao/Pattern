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
            Weapon weapon = new Sword();
            weapon.Kill();
            weapon = new Bone();
            weapon.Kill();
        }
    }
}
