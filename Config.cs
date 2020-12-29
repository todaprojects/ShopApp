using System;
using System.IO;

namespace ShopApp
{
    public class Config
    {
        /// <summary>
        /// (IsDefaultConsole = false) => default input/printer are handled from/to files
        /// </summary>
        public const bool IsDefaultConsole = true;

        private static string appPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        
        public static readonly string InputFilePath = $@"{appPath}\Files\InputFile.txt";
        public static readonly string OutputFilePath = $@"{appPath}\Files\OutputFile.txt";
    }
}