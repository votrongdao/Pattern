#region

// File: RunProxy.cs
// Coder: Sergiy Lischuk
// Created: 10.10.2013  23:32
// Email: evertodante@gmail.com

using Proxy.Abstract;
using Proxy.Proxy;
using RunPattern;

#endregion

namespace Proxy
{
    public class RunProxy : Run
    {
        private IOutputWritter _writter;

        public override void RunApp()
        {
            _writter = new ConsoleWritter();
            var cells = new AbstractCell[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i + j%2 == 0)
                    {
                        cells[i, j] = new ProxyMine(i, j);
                    }
                    else
                    {
                        cells[i, j] = new EmptyProxy(i, j);
                    }
                }
            }

            //Open
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    //this case will be run after cells start drawing
                    cells[i, j].Open();
                }
            }

        }
    }
}