
using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    class Bone:Weapon
    {
        public override int Damage { get; set; }

        public Bone()
        {
            Type = new BoneType();

        }
    }
}
