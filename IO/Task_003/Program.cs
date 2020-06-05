using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла(text.txt): ");
            var fileName = Console.ReadLine();

            Console.WriteLine("Введите путь к файлу: ");
            var path = Console.ReadLine();
            
            var myFile = new MyFile();
            
            myFile.GetDirectory(fileName, path);
            
            ShowMenu("открыть", myFile);
            ShowMenu("сжать", myFile);

        }

        private static void ShowMenu(string text, MyFile file)
        {
            Console.WriteLine($"Чтобы {text} файл нажмите любую кнопку...");
            Console.ReadKey();

            switch (text)
            {
                case "открыть":
                    Console.WriteLine(file.ReadFile());
                    break;
                case "сжать":
                    Console.WriteLine("Введите имя сжатого файла(text.zip): ");
                    var compressedFileName = Console.ReadLine();
            
                    file.CompressFile(compressedFileName);
                    break;
            }
        }
    }
}