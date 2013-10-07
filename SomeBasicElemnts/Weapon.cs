using System;
using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public abstract class Weapon
    {
        public int Damage;
        public IWeaponType Type;
        public string Name;

        protected Weapon(int damage, string name)
        {
            Damage = damage;
            Name = name;
        }

        public void Kill()
        {
            Console.WriteLine("Weapon type :"+Name);
            Console.WriteLine("Weapon damage: "+ Damage);
            Type.GetAndKill();
        }
    }
}
