// File: RocketBarrage.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  17:12
// Email: evertodante@gmail.com

#region

using System;

#endregion

namespace Command.Object
{
    /// <summary>
    /// Some "secret" function :)
    /// </summary>
    public class RocketBarrage
    {
        public int Count { get; set; }
        public string Target { get; set; }

        public RocketBarrage()
        {
            Count = 20;
            Target = "No Target!";
        }

        public void SetAndLaunch(string target, int count)
        {
            Target = target;
            if (count <= Count)
            {
                Count -= count;
            }
            else
            {
                throw new Exception("Error!!! Need load more rocket");
            }
        }
        public override string ToString()
        {
            return String.Format("Target: {0}\n Count: {1}\n", Target, Count);
        }
    }
}