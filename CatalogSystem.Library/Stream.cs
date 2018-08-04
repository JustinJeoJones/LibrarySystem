using System;
using System.IO;

namespace CatalogSystem.Library
{
    public sealed class Stream
    {
        private static Stream instance = new Stream();

        public static string path = $"{Directory.GetCurrentDirectory()}\\catalog.csv";

        public static bool FileExists()
        {
            return File.Exists(path);
        }

        public static Stream getInstance()
        {
            return instance;
        }

        public static void ReadCatalogFile()
        {
            int counter = 0;
            if (FileExists())
            {
                using (var reader = new StreamReader(path))
                {
                    Console.WriteLine();
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine($"{reader.ReadLine()}");
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
    }
}