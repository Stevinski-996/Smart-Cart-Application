using System;
using System.Collections.Generic;
using Smart_Cart_Application;

namespace Smart_Cart_Application{
public class ProductGenerator
{
    private Random random = new Random();
        private string[] foodProducts = new string[] { "Apple", "Bread", "Milk", "Cheese", "Eggs" };
        private string[] clothingProducts = new string[] { "Shirt", "Pants", "Jacket", "Socks", "Hat" };
        private string[] electronicsProducts = new string[] { "Laptop", "Smartphone", "Headphones", "Tablet", "Camera" };


    public Product GenerateRandomProduct(ProductCategory category)
 {
     string[] productNames;

     switch (category)
     {
         case ProductCategory.Food:
             productNames = foodProducts;
             break;
         case ProductCategory.Clothing:
             productNames = clothingProducts;
             break;
         case ProductCategory.Electronics:
             productNames = electronicsProducts;
             break;
         default:
             throw new ArgumentException("Invalid product category");
     }

     var randomName = productNames[random.Next(productNames.Length)];
     var randomPrice = Math.Round((random.Next(50, 150) + random.NextDouble()), 2);
     return new Product(randomName, randomPrice, category);
 
 }

}}