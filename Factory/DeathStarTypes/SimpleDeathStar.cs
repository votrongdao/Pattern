// File: SimpleDeathStar.cs
// Coder: Sergiy Lischuk
// Created: 01:10:2013  13:55
// Email: evertodante@gmail.com

#region

using FactoryMethod.Factories;

#endregion

namespace FactoryMethod.DeathStarTypes
{
    /// <summary>
    /// <see cref="BiGDeathStar"/>
    /// </summary>
    internal class SimpleDeathStar : DeathStar
    {
        public SimpleDeathStar(string name) : base(name)
        {
            Capacity = 100;
        }
    }
}