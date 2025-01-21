namespace Sales.Tax.Product.Model;
using Sales.Tax.Products.Abstractions;
using Sales.Tax.Products.Model;

public class Other : Product
{
    public override ProductKind ProductType => ProductKind.Others;

    public Other(string Name, int Quantity, bool IsImported, double Price)
    {
        this.Name = Name;
        this.Quantity = Quantity;
        this.IsImported = IsImported;
        this.Price = Price;
    }
}
