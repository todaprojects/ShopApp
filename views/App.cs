using System;

namespace ShopApp.helpers
{
    public static class App
    {
        public static void Show(Message message)
        {
            switch (message)
            {
                case Message.Welcome:
                    Console.Write("Type \"command\" or help: ");
                    break;
                case Message.CommandList:
                    Console.WriteLine("Available commands: " +
                                      "\n\tList\t\t\t\t- Display all available items" +
                                      "\n\tBuy \"ItemName\" \"ItemQuantity\"\t- Buy wanted quantity of the item, e.g. Buy Candy 20" +
                                      "\n\tAdd \"ItemName\" \"ItemQuantity\"\t- Increase quantity of sellable item, e.g. Add Cup 30" +
                                      "\n\tShow Balance\t\t\t- Display your current balance" +
                                      "\n\tTopup \"AmountOfMoney\"\t\t- Add money to your balance, e.g. Topup 30");
                    break;
                case Message.UndefinedCommand:
                    Console.WriteLine("Undefined command, try again!");
                    break;
                case Message.NotEnoughMoney:
                    Console.WriteLine("Your current balance is not enough. ");
                    break;
                case Message.MoneyAdded:
                    Console.WriteLine("You successfully increased your money balance!");
                    break;
                case Message.BalanceIs:
                    Console.Write("Your current balance is: ");
                    break;
                case Message.ItemSold:
                    Console.WriteLine("Your purchase has been completed successfully!");
                    break;
                case Message.ItemNotFound:
                    Console.WriteLine("There is no such item at the shop!");
                    break;
                case Message.WantedQuantityIsTooHigh:
                    Console.WriteLine("Requested quantity is too high!");
                    break;
                case Message.ItemSoldOut:
                    Console.WriteLine("This item has been sold out!");
                    break;
                case Message.ItemAdded:
                    Console.WriteLine("Item has been added successfully!");
                    break;
                case Message.ItemNotAdded:
                    Console.WriteLine("Requested item can not be added!");
                    break;
                default:
                    Console.WriteLine("Not defined message!");
                    break;
            }
        }

        public static string Get(Message message)
        {
            switch (message)
            {
                case Message.ItemSoldOut:
                    return "All items have been sold out!\n";
                default:
                    return null;
            }
        }
    }
}