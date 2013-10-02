// File: IOutputWritter.cs
// Coder: Sergiy Lischuk
// Created: 02:10:2013  20:07
// Email: evertodante@gmail.com

namespace RunPattern
{
    public interface IOutputWritter
    {
        void WriteLine(string output);
        void WriteLine(string output, object[] parameter);
    }
}