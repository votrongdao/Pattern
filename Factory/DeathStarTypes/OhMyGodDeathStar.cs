// File: OhMyGodDeathStar.cs
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
    public class OhMyGodDeathStar : DeathStar
    {
        public OhMyGodDeathStar(string name) : base(name)
        {
            Capacity = 100000;
        }
    }
}