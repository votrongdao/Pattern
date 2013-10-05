namespace Decorator
{
    /// <summary>
    /// All Car will be inverited from this class
    /// </summary>
    public abstract class Car
    {
        public string Description = "Abstract cant say anything";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Price();

    }
}
