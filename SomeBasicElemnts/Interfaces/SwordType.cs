using System;

namespace SomeBasicElemnts.Interfaces
{
    class SwordType:IWeaponType
    {
        public void GetAndKill()
        {
            Console.WriteLine("This is sword type of weapon. It doing 'Swaffffff'");
        }
    }
}
