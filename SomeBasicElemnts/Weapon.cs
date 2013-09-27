using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public abstract class Weapon
    {
        public abstract int Damage { get; set; }
        public IWeaponType Type;

        public void Kill()
        {
            Type.GetAndKill();
        }
    }
}
