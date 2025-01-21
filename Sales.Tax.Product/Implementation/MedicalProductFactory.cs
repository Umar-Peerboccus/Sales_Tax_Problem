namespace Sales.Tax.Products.Implementation;

using Sales.Tax.Products.Abstractions;
using Sales.Tax.Product.Model;

public class MedicalProductFactory : IProductFactory
{
    public Product CreateProduct(string Name, int Quantity, bool IsImported, double Price)
    {
        return new Medical(Name, Quantity, IsImported, Price);
    }
}
