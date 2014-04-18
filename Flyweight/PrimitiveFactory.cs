using System.Collections.Generic;
using Flyweight.LowLevel;

namespace Flyweight
{
    public class PrimitiveFactory
    {
        private readonly IDictionary<int, Square> _squareCache;
        private readonly IDictionary<int, Rectangle> _rectangleCache;
        private Point _lastPoint;


        public PrimitiveFactory()
        {
            _squareCache = new Dictionary<int, Square>();
            _rectangleCache = new Dictionary<int, Rectangle>();
        }


        internal Image CreateImage(IEnumerable<Primitive> primitives)
        {
            return new Image(primitives);
        }

        internal Square CreateSquare(int squareborder)
        {
            if (!_squareCache.ContainsKey(squareborder))
            {
                _squareCache.Add(new KeyValuePair<int, Square>(squareborder, new Square(squareborder)));
            }

            return _squareCache[squareborder];
        }

        internal Point CreatePoint(int x, int y)
        {
            if (_lastPoint==null) //bad way
            {
                _lastPoint = new Point(x,y);
            }

            return _lastPoint;
        }

        internal Rectangle CreateRectangle(int hight, int wight)
        {
            if (!_rectangleCache.ContainsKey(hight*wight)) // bad way. We can use rectangle with border 10x5 and 5x10 equality
            {
                _rectangleCache.Add(new KeyValuePair<int, Rectangle>(hight*wight, new Rectangle(hight, wight)));
            }

            return _rectangleCache[hight*wight];
        }
    }
}
