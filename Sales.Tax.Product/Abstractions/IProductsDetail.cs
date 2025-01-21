namespace Sales.Tax.Products.Abstractions;

public interface IProductsDetail
{
    public IList<Product> ProductList { get; set; }
    public string DisplayProducts();
}
