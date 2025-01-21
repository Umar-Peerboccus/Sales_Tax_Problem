namespace Sales.Tax.Products.Implementation;

using Sales.Tax.Products.Abstractions;
using Sales.Tax.Products.Model;

public class BookProductFactory : IProductFactory
{
    public Product CreateProduct(string Name, int Quantity, bool IsImported, double Price)
    {
        return new Book(Name, Quantity, IsImported, Price);
    }
}
