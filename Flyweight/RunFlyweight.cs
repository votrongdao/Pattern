using System.Collections.Generic;
using Flyweight.Context;
using Flyweight.LowLevel;
using RunPattern;

namespace Flyweight
{
    public class RunFlyweight:Run
    {
        public override void RunApp()
        {
            IOutputWritter writter = new ConsoleWritter();
            writter.WriteLine("Run flyweight graphical redactor...");
            writter.WriteLine("Run abstract factory for creating primitives");

            PrimitiveFactory factory = new PrimitiveFactory();
            List<Primitive> primitives = new List<Primitive>()
            {
                factory.CreatePoint(10,20),
                factory.CreateRectangle(15,20),
                factory.CreateSquare(5),
                factory.CreateSquare(5),
                factory.CreateRectangle(100,100)
            };

            Image image = factory.CreateImage(primitives);
            DrawContext contextForDrawing = new DrawContext(640,480, "RED");
            image.DrawSelf(contextForDrawing);
            
            writter.WriteLine("... new context ...");
            image.DrawSelf(new DrawContext(1024,768, "BLUE"));

        }
    }
}
