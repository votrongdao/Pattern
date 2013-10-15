// File: AbstractCell.cs
// Coder: Sergiy Lischuk
// Created: 15.10.2013  14:23
// Email: evertodante@gmail.com

namespace Proxy.Abstract
{
    public enum CellStatus
    {
        Closed,
        Open
    }

    /// <summary>
    ///     In this case we will design a game "Miner"
    /// </summary>
    public abstract class AbstractCell
    {
        protected readonly int _left;
        protected readonly int _top;
        protected CellStatus _status;

        protected AbstractCell(int left, int top)
        {
            _left = left;
            _top = top;
            _status = CellStatus.Closed;
        }

        public virtual int Left
        {
            get { return _left; }
        }

        public virtual int Top
        {
            get { return _top; }
        }

        public virtual CellStatus Status
        {
            get { return _status; }
        }

        public virtual void Open()
        {
            _status = CellStatus.Open;
        }


        //ABSTRACT
        public abstract int PointForOpen();
    }
}