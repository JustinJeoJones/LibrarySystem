using System;
using System.IO;

namespace CatalogSystem.Library
{
    public sealed class Stream
    {
        private static Stream instance = new Stream();

        public static string path = Directory.GetCurrentDirectory() + "Catalog.txt";

        private Stream()
        {
            
        }

        public static Stream getInstance()
        {
            return instance;
        }
    }
}