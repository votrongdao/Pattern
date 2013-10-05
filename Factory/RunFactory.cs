// File: RunFactory.cs
// Coder: Sergiy Lischuk
// Created: 01:10:2013  13:47
// Email: evertodante@gmail.com

#region

using FactoryMethod.Factories;
using RunPattern;

#endregion

namespace FactoryMethod
{
    //Darth Vader collect his army....
    public class RunFactory : Run
    {
        /// <summary>
        /// Now we trying to uderstand pattern FactoryMethod
        /// </summary>
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();
            var factory = new DeathStarFactory();
            var deathStar = factory.CreateDeathStar("DarthVaderLoveHisMom", 10000, 2500);
            writter.WriteLine(deathStar.ToString());
            deathStar = factory.CreateDeathStar("BB Watson", 250, 125);
            writter.WriteLine(deathStar.ToString());
        }
    }
}