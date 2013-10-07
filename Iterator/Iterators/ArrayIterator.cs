#region

// File: ArrayIterator.cs
// Coder: Sergiy Lischuk
// Created: 07:10:2013  19:30
// Email: evertodante@gmail.com



using Iterator.Entity;
using Iterator.Interface;

#endregion



namespace Iterator.Iterators
{
    /// <summary>
    /// Array iteraror
    /// </summary>
    internal class ArrayIterator : IIterator
    {
        private readonly Task[] _task;
        private int _count;

        public ArrayIterator(Task[] task)
        {
            _task = task;
            _count = 0;
        }

        public bool HasNext()
        {
            return _count < _task.Length && _task[_count] != null;
        }

        public object Next()
        {
           Task t = _task[_count];
           _count++;
            return t;
        }
    }
}