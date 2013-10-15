#region

// File: MineCell.cs
// Coder: Sergiy Lischuk
// Created: 15.10.2013  14:41
// Email: evertodante@gmail.com

using Proxy.Abstract;

#endregion

namespace Proxy.Impl
{
    /// <summary>
    ///     This show us a cell with mine and if we opened it we get 100 point
    /// </summary>
    public class MineCell : AbstractCell
    {
        public MineCell(int left, int top) : base(left, top)
        {
        }

        public override int PointForOpen()
        {
            return 100;
        }
    }
}