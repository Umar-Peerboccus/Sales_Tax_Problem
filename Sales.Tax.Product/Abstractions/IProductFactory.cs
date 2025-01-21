namespace Sales.Tax.Products.Abstractions;

public interface IProductFactory
{
    public Product CreateProduct(string Name, int Quantity, bool IsImported, double Price);
}
