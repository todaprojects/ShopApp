using System;
using System.IO;
using ShopApp.Interfaces;

namespace ShopApp.Services
{
    public class FilePrinterService : IPrinterService
    {
        private readonly string _path;

        public FilePrinterService(string outputFilePath)
        {
            if (Directory.Exists(outputFilePath) || File.Exists(outputFilePath))
            {
                _path = outputFilePath;
                using var sw = new StreamWriter(_path);
                sw.Close();
            }
        }

        public void Print(string text)
        {
            if (_path == null) throw new Exception("Output file has not been created!");
            
            using var sw = new StreamWriter(_path, true);
            sw.WriteLine(text);
            sw.Close();
        }
    }
}