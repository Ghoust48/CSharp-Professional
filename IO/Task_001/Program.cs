using System;
using System.IO;

namespace Task_001
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu("создать");
            CreateDirectories();
            
            ShowMenu("удалить");
            DeleteDirectories();

            Console.ReadLine();
        }

        private static void ShowMenu(string message)
        {
            Console.WriteLine($"Чтобы {message} директории нажмите любую клавишу...");
            Console.ReadKey();
        }

        private static void CreateDirectories()
        {
            for (var i = 0; i < 100; i++)
            {
                Directory.CreateDirectory($"./Folder_0{i}");
            }
        }
        
        private static void DeleteDirectories()
        {
            for (var i = 0; i < 100; i++)
            {
                Directory.Delete($"./Folder_0{i}");
            }
        }
    }
}