#region

// File: EmptyCell.cs
// Coder: Sergiy Lischuk
// Created: 15.10.2013  14:33
// Email: evertodante@gmail.com

using Proxy.Abstract;

#endregion

namespace Proxy.Impl
{
    /// <summary>
    ///     This is a empty cell and when we opened it we get only 10 point
    /// </summary>
    public class EmptyCell : AbstractCell
    {
        public EmptyCell(int left, int top) : base(left, top)
        {
        }

        public override int PointForOpen()
        {
            return 10;
        }
    }
}