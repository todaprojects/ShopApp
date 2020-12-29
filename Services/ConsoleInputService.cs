using System;
using ShopApp.Interfaces;

namespace ShopApp.Services
{
    public class ConsoleInputService : IInputService
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}