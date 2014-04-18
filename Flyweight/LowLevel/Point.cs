using Flyweight.Context;
using RunPattern;

namespace Flyweight.LowLevel
{
    internal class Point:Primitive
    {
        private int XPos { get; set; }
        private int YPos { get; set; }

        public Point(int xPos, int yPos) : base(new ConsoleWritter())
        {
            XPos = xPos;
            YPos = yPos;
        }

        public override void DrawSelf(DrawContext drawContext)
        {
            _writter.WriteLine(string.Format("Drawing point on {0}, {1} with color {2}", drawContext.XPos,
                drawContext.Ypos, drawContext.ColorForDrawing));
            _writter.WriteLine(string.Format("Inner parameters of point is: X {0}, Y {1}", XPos, YPos));
        }
    }
}
