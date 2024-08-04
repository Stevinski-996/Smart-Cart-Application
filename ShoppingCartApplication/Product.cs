using System;
using System.Collections.Generic;


namespace Smart_Cart_Application
 {
    public enum ProductCategory {
        Food,
        Clothing,
        Electronics
    }

    public class Product {
         public string Name { get; set; }
         public double Price { get; set; }
         public ProductCategory Category { get; set; }
         public Product(string name, double price, ProductCategory category) {
            Name = name;
            Price = price;
            Category = category;
         }
         
    }
}