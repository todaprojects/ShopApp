using System;
using ShopApp.Helpers;
using ShopApp.Models;
using ShopApp.Services;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = ModelFactory.GetShop();
            shop.Items.Add(ModelFactory.GetItem("Book", 12.90M));
            shop.Items.Add(ModelFactory.GetItem("Candy", 4.90M));
            shop.Items.Add(ModelFactory.GetItem("Cup", 9.90M));

            var user = ModelFactory.GetUser();

            var printer = ServiceFactory.GetPrinter();
            var inputHandler = ServiceFactory.GetInputHandler();

            var runApp = true;
            while (runApp)
            {
                try
                {
                    printer.Print(Message.Welcome);

                    var userArgs = StringParser.Parse(inputHandler.GetInput());

                    switch (userArgs[0])
                    {
                        case "help":
                            printer.Print(Message.CommandList);
                            break;
                        case "list":
                            printer.Print(shop.GetItemList());
                            break;
                        case "buy":
                            var buyItem = userArgs[1];
                            var buyQuantity = int.Parse(userArgs[2]);
                            var buyMessage = shop.SellItem(user, buyItem, buyQuantity);
                            printer.Print(buyMessage);
                            break;
                        case "add":
                            var addItem = userArgs[1];
                            var addQuantity = IntegerParser.Parse(userArgs[2]);
                            var addItemMessage = shop.AddItem(addItem, addQuantity);
                            printer.Print(addItemMessage);
                            break;
                        case "show":
                            if (userArgs[1].ToLower() != "balance") throw new ArgumentException();
                            printer.Print($"{Message.BalanceIs} {user.Balance}\n");
                            break;
                        case "topup":
                            var moneyAmount = DecimalParser.Parse(userArgs[1]);
                            var addBalanceMessage = user.AddBalance(moneyAmount);
                            printer.Print(addBalanceMessage);
                            break;
                        case "exit":
                            runApp = false;
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                catch (ArgumentException e)
                {
                    printer.Print(Message.UndefinedCommand);
                }
                catch (Exception e)
                {
                    runApp = false;
                    printer.Print(e.Message);
                }
            }

            printer.Print(Message.ExitProgram);
        }
    }
}