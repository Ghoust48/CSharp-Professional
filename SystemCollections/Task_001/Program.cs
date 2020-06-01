using System;
using System.Collections;

namespace SystemCollections
{
    class MyClass : IComparer
    {
        private CaseInsensitiveComparer _compare = new CaseInsensitiveComparer();
        
        public int Compare(object? x, object? y)
        {
            return _compare.Compare(y, x);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList {{"Second", 2}, {"First", 1}, {"Third", 3}};


            foreach (DictionaryEntry entry in list)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }

            var sorted = new SortedList(new MyClass()) {{"Second", 2}, {"First", 1}, {"Third", 3}};


            foreach (DictionaryEntry entry in sorted)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
        }
    }
}