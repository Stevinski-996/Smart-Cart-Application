using System;
using System.Collections.Generic;
using Smart_Cart_Application;


namespace Smart_Cart_Application {

    public class Shoppingcart {
        public List<Product> items;

        public Shoppingcart(){
            items = new List<Product>();

        }
        public void Add(Product product){
            items.Add(product);
            Console.WriteLine($"{product.Name} Has been Added to your Cart");
        }
        public void Removeitem(Product item) {
           if (items.Contains(item)){
            items.Remove(item);
            Console.WriteLine($"{item.Name} has been deleted successfully!");
            }else {
                Console.WriteLine($"{item.Name} not found.");
            }
        }
        public void ViewItems() {
            if (items.Count == 0) 
            {
                System.Console.WriteLine("Your Cart is Empty");
                return;
            }
            System.Console.WriteLine("Cart Contents :");
            foreach (Product product in items) {
                Console.WriteLine($"{product.Name} - {product.Price} - {product.Category}");

            }
            Console.WriteLine("Would you like to remove any items? (yes/no)");
        string response = Console.ReadLine();
        if (response.ToLower() == "yes")
        {
            Console.WriteLine("Enter the name of the item to remove:");
            string itemName = Console.ReadLine();
            Product productToRemove = items.Find(i => i.Name.ToLower() == itemName.ToLower());
            if (productToRemove != null)
            {
                Removeitem(productToRemove);
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

    }
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in items) 
    { 
        totalCost += product.Price; 
    }
    return totalCost;
        }
    public List<Product> GetItems()
        {
            return items;
    }
}
}
    
