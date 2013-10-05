
using RunPattern;
using SomeBasicElemnts.Interfaces;

namespace SomeBasicElemnts
{
    public class Bone:Weapon
    {
        public Bone(string name,int dmg, IOutputWritter writter):base(dmg, name, writter)
        {
            Type = new BoneType();

        }
    }
}
