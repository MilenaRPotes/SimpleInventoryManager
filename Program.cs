using System;
using SimpleInventoryManager;

namespace SimpleInventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an inventory instance
            Inventory inventory = new Inventory();
            bool continueRunning = true;

            // Menu options
            while (continueRunning)
            {
                Console.WriteLine("\n INVENTORY MANAGER");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Show Products");
                Console.WriteLine("3. Sell Product");
                Console.WriteLine("4. Remove Product");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Product name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("$ Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        inventory.AddProduct(name, price, quantity);
                        break;

                    case "2":
                        inventory.ShowProducts();
                        break;

                    case "3":
                        Console.WriteLine("Product name to sell: ");
                        string nameToSell = Console.ReadLine();
                        Console.WriteLine("Quantity to sell: ");
                        int quantityToSell = Convert.ToInt32(Console.ReadLine());

                        inventory.SellProduct(nameToSell, quantityToSell);
                        break;

                    case "4":
                        Console.WriteLine("Product name to remove: ");
                        string nameToRemove = Console.ReadLine();
                        inventory.RemoveProduct(nameToRemove);
                        break;

                    case "5":
                        continueRunning = false;
                        Console.WriteLine("Exiting the program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option, try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

