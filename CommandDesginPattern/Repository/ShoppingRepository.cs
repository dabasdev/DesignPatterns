using CommandDesignPattern.Model;

namespace CommandDesignPattern.Repository;

public class ShoppingRepository : IShoppingRepository
{
    public readonly Dictionary<int, (Product product, int quantity)> ShoppingCart = new();

    public void AddProduct(Product? product)
    {
        if (ShoppingCart.ContainsKey(product!.Id))
        {
            IncreaseQuantity(product.Id);
        }
        else
        {
            ShoppingCart[product.Id] = (product, 1);
        }
    }

    public (Product product, int quantity)? GetById(int id)
    {
        if (ShoppingCart.ContainsKey(id))
        {
            return ShoppingCart[id];
        }

        return null;
    }

    public IEnumerable<(Product product, int quantity)> GetAll()
    {
        return ShoppingCart.Values;
    }

    public void RemoveAll(int id)
    {
        ShoppingCart.Remove(id);
    }

    public void IncreaseQuantity(int id)
    {
        if (!ShoppingCart.ContainsKey(id)) return;

        var item = ShoppingCart[id];

        item.quantity += 1;
    }

    public void DecreaseQuantity(int id)
    {
        if (!ShoppingCart.ContainsKey(id)) return;

        var item = ShoppingCart[id];

        if (item.quantity == 1)
            ShoppingCart.Remove(id);

        else
            item.quantity -= 1;
    }
}