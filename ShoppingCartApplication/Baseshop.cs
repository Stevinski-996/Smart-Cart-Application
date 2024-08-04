using System;
using System.Collections.Generic;
using Smart_Cart_Application;


namespace  Smart_Cart_Application{
public abstract class Shop
{
    protected List<Product> products;

    public Shop()
    {
        products = new List<Product>();
        InitializeProducts();
    }

    protected abstract void InitializeProducts();

    public void DisplayProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        Console.WriteLine("Available products:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - ${product.Price} - {product.Category}");
        }
    }

    public Product SelectProduct(string productName)
    {
        Product selectedProduct = products.Find(p => p.Name.ToLower() == productName.ToLower());
        if (selectedProduct == null)
        {
            Console.WriteLine("Product not found.");
        }
        return selectedProduct;
    }
}}