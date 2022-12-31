using CommandDesignPattern.Model;

namespace CommandDesignPattern.Repository;

public interface IShoppingRepository
{
    (Product product , int quantity)? GetById(int id);
    IEnumerable<(Product product, int quantity)> GetAll();
    void AddProduct(Product? product);
    void RemoveAll(int id);
    void IncreaseQuantity(int id);
    void DecreaseQuantity(int id);
}