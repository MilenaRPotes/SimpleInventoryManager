using System;
using SimpleInventoryManager;

namespace SimpleInventoryManager
{
    class Inventory
    {
        // List of products
        private List<Product> products = new List<Product>();

        // Method to add products to the inventory
        public void AddProduct(string name, double price, int quantity)
        {
            Product newProduct = new Product(name, price, quantity);
            products.Add(newProduct);
            Console.WriteLine($"Product added: {newProduct}");
        }

        // Method to display the products in the inventory
        public void ShowProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products in the inventory.");
            }
            else
            {
                Console.WriteLine("\nInventory:");
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }

        // Method to sell products
        public void SellProduct(string name, int quantitySold)
        {
            Product product = products.Find(p => p.Name.ToLower() == name.ToLower());

            if (product != null)
            {
                if (product.Quantity >= quantitySold)
                {
                    product.Quantity -= quantitySold;
                    Console.WriteLine($"Sold: {quantitySold} units of {name}");

                    // If the quantity is 0, remove the product
                    if (product.Quantity == 0)
                    {
                        products.Remove(product);
                        Console.WriteLine($"{name} is out of stock and has been removed from the inventory.");
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough stock of {name}.");
                }
            }
            else
            {
                Console.WriteLine($"The product {name} does not exist in the inventory.");
            }
        }

        // Method to remove a product
        public void RemoveProduct(string name)
        {
            // Search for the product in the list
            Product product = products.Find(p => p.Name.ToLower() == name.ToLower());
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"The product {name} has been removed from the inventory.");
            }
            else
            {
                Console.WriteLine($"Product {name} not found in the inventory.");
            }
        }
    }
}
