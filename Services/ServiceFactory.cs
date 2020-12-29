namespace ShopApp.Services
{
    public static class ServiceFactory
    {
        public static IInputService GetInputHandler()
        {
            if (Config.IsDefaultConsole)
            {
                return new ConsoleInputService();
            }

            return new FileInputService(Config.InputFilePath);
        }

        public static IPrinterService GetPrinter()
        {
            if (Config.IsDefaultConsole)
            {
                return new ConsolePrinterService();
            }

            return new FilePrinterService(Config.OutputFilePath);
        }

        public static IUserBalanceService GetUserBalanceService()
        {
            return new BaseUserBalanceService();
        }

        public static IItemSellService GetItemSellService()
        {
            return new BaseItemSellService();
        }

        public static IItemBalanceService GetItemBalanceService()
        {
            return new BaseItemBalanceService();
        }
    }
}