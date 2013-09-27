using System;

namespace SomeBasicElemnts.Interfaces
{
    class BoneType:IWeaponType
    {
        public void GetAndKill()
        {
            Console.WriteLine("This is bone type of weapon. It doing 'Piff' ");
        }
    }
}
