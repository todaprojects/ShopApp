using System;

namespace ShopApp.Services
{
    public class ConsolePrinterService : IPrinterService
    {
        public void Print(string text)
        {
            Console.Write($"{text}");
        }
    }
}