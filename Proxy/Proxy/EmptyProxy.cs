#region

// File: EmptyProxy.cs
// Coder: Sergiy Lischuk
// Created: 15.10.2013  14:43
// Email: evertodante@gmail.com

using Proxy.Abstract;
using Proxy.Impl;

#endregion

namespace Proxy.Proxy
{
    /// <summary>
    /// Proxy for EmptyCell
    /// </summary>
    public class EmptyProxy : AbstractCell
    {
        private EmptyCell _cell;

        public EmptyProxy(int left, int top) : base(left, top)
        {
            _cell = null;
        }

        public override int Left
        {
            get { return _cell == null ? _left : _cell.Left; }
        }

        public override int Top
        {
            get { return _cell == null ? _left : _cell.Top; }
        }

        public override CellStatus Status
        {
            get { return _cell == null ? _status : _cell.Status; }
        }

        public override void Open()
        {
            if (_cell == null)
            {
                _cell = new EmptyCell(_left, _top);
            }
            _cell.Open();
        }


        public override int PointForOpen()
        {
            return _cell == null ? 10 : _cell.PointForOpen();
        }
    }
}