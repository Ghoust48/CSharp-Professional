using System;

namespace Task_003
{
    public interface IFamily
    {
        string Name { get; }
        
        DateTime Birthday { get; }
        
        IFamily Parent { get; }
    }
}