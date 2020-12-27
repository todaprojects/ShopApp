using System;
using System.Text.RegularExpressions;
using ShopApp.Factories;
using ShopApp.Models;
using ShopApp.Views;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            shop.User = UserFactory.GetWithBalance(50);
            
            shop.Items.Add(ItemFactory.Get("Book"));
            shop.Items.Add(ItemFactory.Get("Candy"));
            shop.Items.Add(ItemFactory.Get("Cup"));
            
            var runApp = true;
            while (runApp)
            {
                App.Show(message: Message.Welcome);

                var input = Console.ReadLine()?.ToLower();
                var userArgs = Regex.Split(input ?? string.Empty, "\\s+");

                try
                {
                    switch (userArgs[0])
                    {
                        case "help":
                            App.Show(Message.CommandList);
                            break;
                        case "list":
                            Console.Write(shop.GetItemList());
                            break;
                        case "buy":
                            var wantedItem = userArgs[1];
                            var wantedQuantity = int.Parse(userArgs[2]);
                            shop.Sell(wantedItem, wantedQuantity);
                            break;
                        case "add":
                            var targetItem = userArgs[1];
                            var targetQuantity = int.Parse(userArgs[2]);
                            shop.Add(targetItem, targetQuantity);
                            break;
                        case "show":
                            if (userArgs[1].ToLower() == "balance")
                            {
                                App.Show(Message.BalanceIs);
                                Console.WriteLine(shop.GetUserBalance());
                                break;
                            }
                            throw new ArgumentException();
                        case "topup":
                            var moneyAmount = double.Parse(userArgs[1]);
                            shop.SetUserBalance(moneyAmount);
                            break;
                        case "exit":
                            runApp = false;
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                catch (Exception e)
                {
                    App.Show(Message.UndefinedCommand);
                }
            }
        }
    }
}