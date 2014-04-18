using Flyweight.Context;
using RunPattern;

namespace Flyweight.LowLevel
{
    /// <summary>
    /// Basic class for all future figure 
    /// </summary>
    internal abstract class Primitive
    {
        protected readonly IOutputWritter _writter;

        protected Primitive(IOutputWritter writter)
        {
            _writter = writter;
        }

        /// <summary>
        /// Method for drawing figure
        /// </summary>
        /// <param name="drawContext">Draw context</param>
        public abstract void DrawSelf(DrawContext drawContext); //Draw context is a Context, where save current elements
    }
}
