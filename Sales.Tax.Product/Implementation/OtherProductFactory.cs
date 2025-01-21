namespace Sales.Tax.Products.Implementation;

using Sales.Tax.Products.Abstractions;
using Sales.Tax.Product.Model;

public class OtherProductFactory : IProductFactory
{
    public Product CreateProduct(string Name, int Quantity, bool IsImported, double Price)
    {
        return new Other(Name, Quantity, IsImported, Price);
    }
}
