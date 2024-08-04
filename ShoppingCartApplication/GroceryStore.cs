namespace Smart_Cart_Application{
public class GroceryStore : Shop
{
    protected override void InitializeProducts()
    {
        products.Add(new Product("Apple", 1.2, ProductCategory.Food));
        products.Add(new Product("Bread", 2.5, ProductCategory.Food));
        products.Add(new Product("Milk", 1.0, ProductCategory.Food));
    }
}}