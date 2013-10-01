// File: DeathStarFactory.cs
// Coder: Sergiy Lischuk
// Created: 01:10:2013  13:51
// Email: evertodante@gmail.com

#region

using System;
using FactoryMethod.DeathStarTypes;

#endregion

namespace FactoryMethod.Factories
{
    /// <summary>
    /// Darth build new factory to create his star (opened kickstarter.com)
    /// </summary>
    public class DeathStarFactory
    {
        public DeathStar CreateDeathStar(string nameOfDeathStarShip, int damage, int capacity)
        {
            DeathStar toy;

            if (capacity < 1000)
            {
                toy = new SimpleDeathStar(nameOfDeathStarShip) {Damage = damage};
            }
            else if (capacity > 1000 && capacity < 10000)
            {
                toy = new BiGDeathStar(nameOfDeathStarShip) {Damage = damage};
            }
            else
            {
                toy = new OhMyGodDeathStar(nameOfDeathStarShip) {Damage = damage};
            }

            return toy;
        }
    }

    /// <summary>
    /// Subject what must returned by our factory method
    /// </summary>
    public class DeathStar
    {
        public DeathStar(string name)
        {
            Name = name;
        }

        public int Damage { get; set; }
        public String Name { get; private set; }
        public int Capacity { get; set; }

        public override string ToString()
        {
            return String.Format("AHAHAHAHAH. THiS has come. Behold - {0} with dmg {1} and capacity {2}", Name, Damage,
                                 Capacity);
        }
    }
}