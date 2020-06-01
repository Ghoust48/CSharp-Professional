using System;

namespace Task_003
{
    public class Human : IFamily
    {
        public string Name { get; }
        
        public DateTime Birthday { get; }
        
        public IFamily Parent { get; }

        public Human(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        
        public Human(string name, DateTime birthday, IFamily parent) : this(name, birthday)
        {
            Parent = parent;
        }

        public override string ToString()
        {
            return $"{Name}, {Birthday})";
        }
    }
}