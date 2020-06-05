using System;
using System.IO;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла: ");
            var fileName = Console.ReadLine();
            
            Console.WriteLine("Введите текст: ");
            var text = Console.ReadLine();
            
            CreateFile(fileName, text);

            Console.WriteLine("Нажмите любую клавишу чтобы прочитать файл");
            Console.ReadKey();
            
            ReadFile(fileName);
        }

        private static void CreateFile(string fileName, string message)
        {
            using (var writer = new StreamWriter(new FileStream($"{Directory.GetCurrentDirectory()}\\{fileName}", FileMode.OpenOrCreate)))
            {
                writer.Write(message);
                Console.WriteLine("Файл успешно создан!");
            }
        }

        private static void ReadFile(string path)
        {
            using (var reader = new StreamReader(new FileStream(path, FileMode.OpenOrCreate)))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}