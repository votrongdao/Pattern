#region

// File: ProxyMine.cs
// Coder: Sergiy Lischuk
// Created: 15.10.2013  14:52
// Email: evertodante@gmail.com

using Proxy.Abstract;
using Proxy.Impl;

#endregion

namespace Proxy.Proxy
{
    /// <summary>
    /// Proxy for mine cell
    /// </summary>
    public class ProxyMine : AbstractCell
    {
        private MineCell _proxyCell;

        public ProxyMine(int left, int top) : base(left, top)
        {
            _proxyCell = null;
        }

        public override int Left
        {
            get { return _proxyCell == null ? _left : _proxyCell.Left; }
        }

        public override int Top
        {
            get { return _proxyCell == null ? _top : _proxyCell.Top; }
        }

        public override CellStatus Status
        {
            get { return _proxyCell == null ? _status : _proxyCell.Status; }
        }

        public override void Open()
        {
            if (_proxyCell == null)
            {
                _proxyCell = new MineCell(_left, _top);
            }
            _proxyCell.Open();
        }

        public override int PointForOpen()
        {
            return _proxyCell == null ? 100 : _proxyCell.PointForOpen();
        }
    }
}