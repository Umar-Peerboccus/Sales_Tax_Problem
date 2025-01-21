namespace Sales.Tax.Products.Abstractions;
using Sales.Tax.Products.Model;

public abstract class Product
{
    public string Name { get; set; } = default!;
    public virtual ProductKind ProductType { get; set; }
    public int Quantity { get; set; }
    public bool IsImported { get; set; }

    public double SalesTaxAmount { get; set; }
    public double Price { get; set; }

}
