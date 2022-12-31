using CommandDesignPattern.Model;
using CommandDesignPattern.Repository;

namespace CommandDesignPattern.Commands;

public class AddToCardCommand : ICommand
{
    private readonly Product? _product;
    private readonly ProductRepository _productRepository;
    private readonly ShoppingRepository _shoppingRepository;

    public AddToCardCommand(Product product, ProductRepository productRepository, ShoppingRepository shoppingRepository)
    {
        _product = product;
        _productRepository = productRepository;
        _shoppingRepository = shoppingRepository;
    }

    public bool CanExecute()
    {
        if(_product == null) return false;

        return _productRepository.GetStockFor(_product.Id) > 0;
    }

    public void Execute()
    {
        if (_product == null) return ;
        _productRepository.DecreaseStockBy(_product.Id , 1);
        _shoppingRepository.AddProduct(_product);
    }

    public void Undo()
    { 
        if (_product == null) return;
        var lineItem = _shoppingRepository.ShoppingCart[_product.Id];
        _productRepository.IncreaseStockBy(_product.Id , lineItem.quantity);
        _shoppingRepository.RemoveAll(_product.Id);
    }


}