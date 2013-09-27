
using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public class Bone:Weapon
    {
        public Bone(string name,int dmg):base(dmg, name)
        {
            Type = new BoneType();

        }
    }
}
