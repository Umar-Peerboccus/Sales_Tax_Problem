
namespace Sales.Tax.Product.Model;
using Sales.Tax.Products.Abstractions;
using Sales.Tax.Products.Model;

public class Food : Product
{
    public override ProductKind ProductType => ProductKind.Food;

    public Food(string Name, int Quantity, bool IsImported, double Price)
    {
        this.Name = Name;
        this.Quantity = Quantity;
        this.IsImported = IsImported;
        this.Price = Price;
    }
}
