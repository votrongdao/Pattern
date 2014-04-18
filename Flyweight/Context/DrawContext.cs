namespace Flyweight.Context
{
    internal class DrawContext
    {
        public int XPos { get; set; }
        public int Ypos { get; set; }
        public string ColorForDrawing { get; set; }

        public DrawContext(int xPos, int ypos, string colorForDrawing)
        {
            XPos = xPos;
            Ypos = ypos;
            ColorForDrawing = colorForDrawing;
        }
    }
}
