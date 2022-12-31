using CommandDesignPattern.Model;

namespace CommandDesignPattern.Repository;

public class ProductRepository : IProductRepository
{
    private Dictionary<int, (Product product, int stock)> Products { get; }

    public ProductRepository()
    {
        Products = new Dictionary<int, (Product product, int stock)>();

        AddToDictionary(new Product(){Id = 1 , Name = "Samsung A73" , Price = 1099} , 2);
        AddToDictionary(new Product(){Id = 2 , Name = "Samsung S22" , Price = 3500} , 1);
        AddToDictionary(new Product(){Id = 3 , Name = "IPhone 13" , Price = 4520} , 5);
        AddToDictionary(new Product(){Id = 4 , Name = "Xiaomi POCO X4" , Price = 1399 }, 3);
    }

    private void AddToDictionary(Product? product , int stock)
    {
        if(product == null) return;

        Products[product.Id] = (product, stock);
    }
    public Product? GetById(int id)
    {
        return Products.ContainsKey(id) ? Products[id].product : null;
    }

    public int GetStockFor(int id)
    {
        return Products.ContainsKey(id) ? Products[id].stock : 0;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return Products.Select(x => x.Value.product);
    }

    public void DecreaseStockBy(int id, int amount)
    {
        if (!Products.ContainsKey(id)) return;

        var prd = Products[id];
        prd.stock -= amount;

        //Products[id] = (Products[id].product , Products[id].stock + amount);
    }

    public void IncreaseStockBy(int id, int amount)
    {
        if (!Products.ContainsKey(id)) return;

        var prd = Products[id];
        prd.stock += amount;
    }
}