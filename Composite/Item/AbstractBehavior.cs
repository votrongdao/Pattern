#region

// File: AbstractBehavior.cs
// Coder: Sergiy Lischuk
// Created: 08:10:2013  20:41
// Email: evertodante@gmail.com

using System;

#endregion

namespace Composite.Item
{
    /// <summary>
    /// In this class we see that our task will be have a simply methods for add and
    /// remove it from collection
    /// </summary>
    public abstract class AbstractBehavior
    {
        public virtual void Add(AbstractBehavior itemTask)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(AbstractBehavior item)
        {
            throw new NotImplementedException();
        }

        public virtual void GetSub()
        {
            throw new NotImplementedException();
        }
    }
}