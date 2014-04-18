using Flyweight.Context;
using RunPattern;

namespace Flyweight.LowLevel
{
    internal class Rectangle:Primitive
    {
        private int Hight { get; set; }
        private int Width { get; set; }
        
        public Rectangle(int hight, int width):base(new ConsoleWritter())
        {
            Hight = hight;
            Width = width;
        }

        public override void DrawSelf(DrawContext drawContext)
        {
            _writter.WriteLine(string.Format("Drawing rectangle on {0}, {1} with color {2}", drawContext.XPos,
               drawContext.Ypos, drawContext.ColorForDrawing));
            _writter.WriteLine(string.Format("Inner parameters of rectangle is: HIGHT {0}, WIGHT {1}", Hight, Width));
        }
    }
}
