using CommandDesignPattern.Model;

namespace CommandDesignPattern.Repository;

public interface IProductRepository
{
    Product? GetById(int id);
    int GetStockFor(int id);
    IEnumerable<Product> GetAllProducts();
    void DecreaseStockBy(int id , int amount);
    void IncreaseStockBy(int id , int amount);
}