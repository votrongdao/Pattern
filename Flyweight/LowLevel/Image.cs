using System.Collections.Generic;
using Flyweight.Context;
using RunPattern;

namespace Flyweight.LowLevel
{
    internal class Image:Primitive
    {
        private IEnumerable<Primitive> Primitives { get; set; }

        public Image():base(new ConsoleWritter())
        {
            Primitives = new List<Primitive>();
        }

        public Image(IEnumerable<Primitive> primitives):base(new ConsoleWritter())
        {
            Primitives = primitives;
        }


        public override void DrawSelf(DrawContext drawContext)
        {
            foreach (var primitive in Primitives)
            {
                primitive.DrawSelf(drawContext);
            }
        }
    }
}
