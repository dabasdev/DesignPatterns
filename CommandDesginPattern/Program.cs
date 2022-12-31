// See https://aka.ms/new-console-template for more information

using CommandDesignPattern.Commands;
using CommandDesignPattern.Repository;

Console.WriteLine("Hello, World! ... From Command Pattern");

Console.WriteLine();

var productRepo = new ProductRepository();
var shoppingCartRepo = new ShoppingRepository();

var product = productRepo.GetById(4);

//shoppingRepo.AddProduct(product);
//shoppingRepo.IncreaseQuantity(4);
//shoppingRepo.IncreaseQuantity(4);
//shoppingRepo.IncreaseQuantity(4);
//shoppingRepo.IncreaseQuantity(4);


var addToCartCommand = new AddToCardCommand(product!, productRepo, shoppingCartRepo);

var increaseQuantityCommand =
    new ChangeQuantityCommand(ChangeQuantityCommand.Operation.Increase, product!, productRepo, shoppingCartRepo);

var manager = new CommandManager();


manager.Invoke(addToCartCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);

PrintCard(shoppingCartRepo);

manager.Undo();

PrintCard(shoppingCartRepo);

static void PrintCard(IShoppingRepository shoppingRepository)
{
    foreach (var item in shoppingRepository.GetAll())
    {
        Console.WriteLine($"Product Id: {item.product.Id} - ${item.product.Price} ْX {item.quantity} = {item.product.Price * item.quantity}");
    }
}
