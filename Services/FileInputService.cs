using System;
using System.IO;
using ShopApp.Interfaces;

namespace ShopApp.Services
{
    public class FileInputService : IInputService
    {
        private readonly StreamReader _file;

        public FileInputService(string inputFilePath)
        {
            if (File.Exists(inputFilePath))
            {
                _file = new StreamReader(inputFilePath);
            }
        }

        public string GetInput()
        {
            if (_file == null) throw new Exception("Input file has not been found!");

            string line;
            if ((line = _file.ReadLine()) != null)
            {
                return line;
            }

            _file.Close();
            return null;
        }
    }
}