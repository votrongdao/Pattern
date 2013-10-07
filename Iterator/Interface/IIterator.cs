// File: IIterator.cs
// Coder: Sergiy Lischuk
// Created: 07:10:2013  19:12
// Email: evertodante@gmail.com

namespace Iterator.Interface
{
    /// <summary>
    /// This interface helps us to create iterations collection
    /// </summary>
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}