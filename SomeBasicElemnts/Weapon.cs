using RunPattern;
using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public abstract class Weapon
    {
        private readonly IOutputWritter _writter;
        public int Damage;
        public string Name;
        public IWeaponType Type;

        protected Weapon(int damage, string name, IOutputWritter writter)
        {
            Damage = damage;
            Name = name;
            _writter = writter;
        }

        public void Kill()
        {
            _writter.WriteLine("Weapon type :" + Name);
            _writter.WriteLine("Weapon damage: " + Damage);
            _writter.WriteLine(Type.GetAndKill());
        }
    }
}