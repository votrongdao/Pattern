using System;
using Flyweight.Context;
using RunPattern;

namespace Flyweight.LowLevel
{
    internal class Square:Primitive
    {
        public int SquareBorder { get; set; }


        public Square(int squareBorder) : base(new ConsoleWritter())
        {
            SquareBorder = squareBorder;
        }

        public override void DrawSelf(DrawContext drawContext)
        {
            _writter.WriteLine(string.Format("Drawing square on {0}, {1} with color {2}", drawContext.XPos,
               drawContext.Ypos, drawContext.ColorForDrawing));
            _writter.WriteLine(string.Format("Inner parameters of square is: BORDER {0}", SquareBorder));
        }
    }
}
