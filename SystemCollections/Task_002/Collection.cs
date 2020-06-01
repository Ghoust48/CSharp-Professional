using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_002
{
    public class Collection
    {
        private Dictionary<Buyer, List<Category>> _dictionary = new Dictionary<Buyer, List<Category>>();

        public int Count => _dictionary.Count;

        public void Add(Buyer buyer, List<Category> categories)
        {
            _dictionary.Add(buyer, categories);
        }

        public void Categories(Buyer buyer)
        {

            foreach (var item in _dictionary)
            {
                if (item.Key == buyer)
                {
                    foreach (var value in item.Value)
                    {
                        Console.WriteLine(value);
                    }
                }
            }
        }

        public void Buyers(Category category)
        {
            foreach (var item in _dictionary)
            {
                foreach (var value in item.Value)
                {
                    if (value == category)
                    {
                        Console.WriteLine(item.Key);
                    }
                    
                }
            }
        }
    }
}