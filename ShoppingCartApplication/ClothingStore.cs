namespace Smart_Cart_Application{
public class ClothingStore : Shop
{
    protected override void InitializeProducts()
    {
        products.Add(new Product("T-Shirt", 15.0, ProductCategory.Clothing));
        products.Add(new Product("Dress", 40.0, ProductCategory.Clothing));
        products.Add(new Product("Jeans", 25.0, ProductCategory.Clothing));
    }
}
}