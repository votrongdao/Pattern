// File: BiGDeathStar.cs
// Coder: Sergiy Lischuk
// Created: 01:10:2013  13:55
// Email: evertodante@gmail.com

#region

using FactoryMethod.Factories;

#endregion

namespace FactoryMethod.DeathStarTypes
{
    /// <summary>
    /// Darth has a 3 type of his favorite toy
    /// </summary>
    internal class BiGDeathStar : DeathStar
    {
        public BiGDeathStar(string name) : base(name)
        {
            Capacity = 10000;
        }
    }
}