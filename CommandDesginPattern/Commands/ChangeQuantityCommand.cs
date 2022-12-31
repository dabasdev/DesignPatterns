using CommandDesignPattern.Model;
using CommandDesignPattern.Repository;

namespace CommandDesignPattern.Commands;

public class ChangeQuantityCommand : ICommand
{
    public enum Operation
    {
        Increase,
        Decrease
    }

    private readonly Operation _operation;
    private readonly Product _product;
    private readonly ProductRepository _productRepository;
    private readonly ShoppingRepository _shoppingRepository;

    public ChangeQuantityCommand(Operation operation, Product product, ProductRepository productRepository,
        ShoppingRepository shoppingRepository)
    {
        _operation = operation;
        _product = product;
        _productRepository = productRepository;
        _shoppingRepository = shoppingRepository;
    }

    public bool CanExecute()
    {
        return _operation switch
        {
            Operation.Decrease => _shoppingRepository.GetById(_product.Id)!.Value.quantity != 0,
            Operation.Increase => _productRepository.GetStockFor(_product.Id) - 1 >= 0,
            _ => false
        };
    }

    public void Execute()
    {
        switch (_operation)
        {
            case Operation.Decrease:
                _shoppingRepository.DecreaseQuantity(_product.Id);
                _productRepository.IncreaseStockBy(_product.Id, 1);
                break;
            case Operation.Increase:
                _shoppingRepository.IncreaseQuantity(_product.Id);
                _productRepository.DecreaseStockBy(_product.Id, 1);
                break;
            default:
                return;
        }
    }

    public void Undo()
    {
        switch (_operation)
        {
            case Operation.Decrease:
                _shoppingRepository.IncreaseQuantity(_product.Id);
                _productRepository.DecreaseStockBy(_product.Id, 1);
                break;
            case Operation.Increase:
                _shoppingRepository.DecreaseQuantity(_product.Id);
                _productRepository.IncreaseStockBy(_product.Id, 1);
                break;
            default:
                return;
        }
    }
}