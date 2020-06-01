using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new FamilyTree();
            
            var vasya = new Human("Vasya", DateTime.Today);
            var petya = new Human("Petya", DateTime.Today, vasya);
            var vova = new Human("Vova", DateTime.Today, petya);
            var alex = new Human("Alex", DateTime.Today, vova);
            
            tree.Add(vasya);
            tree.Add(petya);
            tree.Add(vova);
            tree.Add(alex);

            tree.GetHumansByBirthday(2020);
            tree.GetHumansByBirthday(2001);

            Console.WriteLine(new string('-', 15));
            
            tree.GetChildren(vasya);
            
            Console.WriteLine(new string('-', 15));
            
            tree.GetChildren(vova);
        }
    }
}