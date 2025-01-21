namespace Sales.Tax.Products.Model;
using Sales.Tax.Products.Abstractions;
using Sales.Tax.Products.Model;

public class Book : Product
{
    public override ProductKind ProductType => ProductKind.Book;

    public Book(string Name, int Quantity, bool IsImported, double Price)
    {
        this.Name = Name;
        this.Quantity = Quantity;
        this.IsImported = IsImported;
        this.Price = Price;
    }
}
