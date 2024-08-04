using System;
using Smart_Cart_Application;

namespace Smart_Cart_Application{
public class Program
{
    public static void Main(string[] args)
    {
        Shoppingcart cart = new Shoppingcart();
        GroceryStore groceryStore = new GroceryStore();
        ClothingStore clothingStore = new ClothingStore();
        
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nWelcome to the Mall! Please choose an option:");
            Console.WriteLine("1. Shop at Grocery Store");
            Console.WriteLine("2. Shop at Clothing Store");
            Console.WriteLine("3. View Shopping Cart");
            Console.WriteLine("4. Calculate Total Cost");
            Console.WriteLine("5. Checkout and Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShopAtStore(groceryStore, cart);
                    break;
                case "2":
                    ShopAtStore(clothingStore, cart);
                    break;
                case "3":
                    cart.ViewItems();
                    break;
                case "4":
                    double totalCost = cart.CalculateTotalCost();
                    Console.WriteLine($"Total cost: ${totalCost}");
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Thank you for shopping! Have a great day!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void ShopAtStore(Shop shop, Shoppingcart cart)
    {
        shop.DisplayProducts();
        Console.WriteLine("Enter the name of the product to add to the cart:");
        string productName = Console.ReadLine();
        Product selectedProduct = shop.SelectProduct(productName);
        if (selectedProduct != null)
        {
            cart.Add(selectedProduct);
        }
    }
}}