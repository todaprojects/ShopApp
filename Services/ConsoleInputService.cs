using System;

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