namespace Infrastructure;

public class StoreManager
{
    List<Product> products = new List<Product>();
    List<Order> orders = new List<Order>();
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void AddProductToOrder(Product product)
    {
        products.Add(product);
    }
    public void GetAllProducts()
    {
        System.Console.WriteLine("Список всех продуктов: ");
        foreach (var item in products)
        {
            System.Console.WriteLine($"Name: {item.GetName()}, Price: {item.GetPrice()}, Quantity: {item.GetQuantity()}");
        }
        System.Console.WriteLine();
    }
    public void GetProductByName(string name)
    {
        System.Console.WriteLine("Вот продукты по имени: ");
        foreach (var item in products)
        {
            if (item.GetName() == name)
            {
                System.Console.WriteLine($"Name: {item.GetName()}, Price: {item.GetPrice()}, Quantity: {item.GetQuantity()}");
            }
        }
        System.Console.WriteLine();
    }
    public bool RemoveProduct(string name)
    {
        System.Console.WriteLine("Удаление по имени: ");
        foreach (var item in products)
        {
            if (item.GetName() == name)
            {
                products.Remove(item);
                return true;
            }
        }
        return false;
    }
    public List<Product> GetProductsByPriceRange(double min, double max)
    {
        List<Product> filterProduct = new List<Product>();
        foreach (var item in products)
        {
            if (item.GetPrice()>= min && item.GetPrice() <= max)
            {
                filterProduct.Add(item);
            }
        }
        return filterProduct;
    }
    public List<Product> GetAvailableProducts()
    {
        List<Product> available = new List<Product>();
        foreach (var item in products)
        {
            if (item.GetQuantity() > 0)
            {
                available.Add(item);
            }
        }
        return available;
    }
}
