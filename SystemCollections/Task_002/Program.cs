using System;
using System.Collections.Generic;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new Collection();

            var igor = new Buyer("Igor");
            var vasya = new Buyer("Vasya");
            var sergey = new Buyer("Sergey");
            
            collection.Add(igor, new List<Category>() {Category.Car, Category.Eat});
            collection.Add(vasya, new List<Category>() {Category.Clothes});
            collection.Add(sergey, new List<Category>() {Category.Eat});

            collection.Categories(igor);

            Console.WriteLine(new string('-', 15));
            
            collection.Buyers(Category.Eat);
            
        }
    }
}