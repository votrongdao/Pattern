#region

// File: Task.cs
// Coder: Sergiy Lischuk
// Created: 07:10:2013  18:55
// Email: evertodante@gmail.com

using System;
using Iterator.Annotations;

#endregion

namespace Iterator.Entity
{
    /// <summary>
    /// This class needs for our collection
    /// </summary>
    public class Task
    {
        public bool Active { get; set; }
        public string Name { get; set; }
        public string WhatDo { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime End { get; set; }

        public Task(bool active, string name, DateTime start, DateTime endTime)
        {
            Active = active;
            Name = name;
            StarTime = start;
            End = endTime;
        }

        public void WhatNeedDo([NotNull] string whatdo)
        {
            if (whatdo == null) throw new ArgumentNullException("whatdo");
            WhatDo = whatdo;
        }

        public override string ToString()
        {
            return string.Format("Task:{0}\n Active:{1}\n What need do?:{2}\n", Name, Active, WhatDo);
        }
    }
}