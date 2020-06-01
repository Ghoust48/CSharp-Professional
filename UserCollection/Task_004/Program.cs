using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary();
            
            dictionary.Add("яблуко", "яблоко", "apple");
            dictionary.Add("ручка", "ручка", "pen");
            dictionary.Add("сонце", "солнце", "sun");

            Console.WriteLine(dictionary["яблуко", "ru"]);
            Console.WriteLine(dictionary["яблуко", "en"]);
        }
    }
}