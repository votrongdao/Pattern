#region

// File: HashtableTask.cs
// Coder: Sergiy Lischuk
// Created: 07:10:2013  19:09
// Email: evertodante@gmail.com

using System.Collections.Generic;
using Iterator.Entity;
using Iterator.Interface;
using Iterator.Iterators;

#endregion

namespace Iterator
{
    /// <summary>
    /// Bad exemple but its good for us
    /// </summary>
    public class ArrayTask
    {
        private readonly Task[] _tasks;
        private int _count;


        public ArrayTask(Task[] tasks, int startcount)
        {
            _tasks = tasks;
            _count = startcount;
        }

        public void AddTask(Task task)
        {
            _count++;
            _tasks[_count]= task;
        }

        public IIterator ArrayIterator()
        {
            return new ArrayIterator(_tasks);
        }
    }
}