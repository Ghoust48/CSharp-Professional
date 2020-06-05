using System.IO;
using System.IO.Compression;

namespace Task_003
{
    public class MyFile
    {
        private string _path;

        public void GetDirectory(string fileName, string path)
        {
            var directories = Directory.GetDirectories(path);
            
            foreach (var directory in directories)
            {
                GetFile(fileName, directory);
            
                if (directories.Length != 0)
                {
                    GetDirectory(fileName, directory);
                }
            }
        }

        private void GetFile(string fileName, string path)
        {
            var files = Directory.GetFiles(path);
                
            foreach (var file in files)
            {
                if (Path.GetFileName(file) == fileName)
                {
                    _path = file;
                }
            }
        }

        public string ReadFile()
        {
            using (var reader = new StreamReader(new FileStream(_path, FileMode.Open)))
            {
                return reader.ReadToEnd();
            }
        }

        public void CompressFile(string compressedFileName)
        {
            using (var sourceFile = new FileStream(_path, FileMode.OpenOrCreate))
            {
                var pathFile = Path.GetDirectoryName(_path);
                
                using (var targetFile = new FileStream($"{pathFile}\\{compressedFileName}", FileMode.OpenOrCreate))
                {
                    using (var compressor = new GZipStream(targetFile, CompressionMode.Compress))
                    {
                        sourceFile.CopyTo(compressor);
                    }
                }
            }
        }
    }
}