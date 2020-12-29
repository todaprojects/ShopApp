namespace ShopApp.Helpers
{
    public class Message
    {
        public const string Welcome = "Type \"command\" or help: ";

        public const string CommandList =
            "Available commands: " +
            "\n\tList\t\t\t\t- Display all available items" +
            "\n\tBuy \"ItemName\" \"ItemQuantity\"\t- Buy wanted quantity of the item, e.g. Buy Candy 20" +
            "\n\tAdd \"ItemName\" \"ItemQuantity\"\t- Increase quantity of sellable item, e.g. Add Cup 30" +
            "\n\tShow Balance\t\t\t- Display your current balance" +
            "\n\tTopup \"AmountOfMoney\"\t\t- Add money to your balance, e.g. Topup 30" +
            "\n\tExit\t\t\t\t- Exit program.\n";

        public const string UndefinedCommand = "Undefined command, try again!\n";
        public const string NotEnoughMoney = "Your current balance is not enough. \n";
        public const string MoneyAdded = "You successfully increased your money balance!\n";
        public const string BalanceIs = "Your current balance is: ";
        public const string ItemSold = "Your purchase has been completed successfully!\n";
        public const string ItemNotFound = "There is no such item at the shop!\n";
        public const string WantedQuantityIsTooHigh = "Requested quantity is too high!\n";
        public const string ItemSoldOut = "This item has been sold out!\n";
        public const string ItemAdded = "Item has been added successfully!\n";
        public const string ItemNotAdded = "Requested item can not be added!\n";
        public const string ExitProgram = "Closing program...\n";
    }
}